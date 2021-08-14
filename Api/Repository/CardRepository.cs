using API_TakeToGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace API_TakeToGit
{
    public static class CardRepository
    {
        public static List<CardModel> GetByLanguage(this List<CardModel> cards, string language)
        {
            return cards.Where(c => c.language!=null && c.language.Equals(language)).ToList();
        }
    }
}