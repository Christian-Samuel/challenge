using API_TakeToGit.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace API_TakeToGit
{
    public static class GitAPI
    {
        public static List<CardModel> allRepository = new List<CardModel>();
        public static string urlAvatar = string.Empty;

        public static void GetRepository()
        {
            if (!allRepository.Any())
            {
               var response = ConectApiGIT();
               SaveResponse(response);
            }
        }

        private static IRestResponse ConectApiGIT()
        {
            var client = new RestClient("https://api.github.com/orgs/takenet/repos");
            var request = new RestRequest(Method.GET);
            return  client.Execute(request);
        }

        private static void SaveResponse(IRestResponse response)
        {
            allRepository = JsonConvert.DeserializeObject<List<CardModel>>(response.Content);
            urlAvatar = allRepository.First().owner.avatar_url;
        }
    }
}