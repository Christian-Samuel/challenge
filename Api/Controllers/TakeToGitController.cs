using API_TakeToGit.Models;
using System;
using System.Web.Http;


namespace API_TakeToGit.Controllers
{
    public class TakeToGitController : ApiController
    {
            [AcceptVerbs("GET")]
            public string GetAvatar()
            {
                GitAPI.GetRepository();

                return GitAPI.urlAvatar;
            }


            [AcceptVerbs("GET")]
            public CardModel GetCard(int id)
            {
                GitAPI.GetRepository();
                var allCards = GitAPI.allRepository;
                var cardsCsharp = allCards.GetByLanguage("C#");

                cardsCsharp.Sort((x, y) => DateTimeOffset.Compare(x.created_at, y.created_at));
               
                return cardsCsharp[id];                
            }

    }
}