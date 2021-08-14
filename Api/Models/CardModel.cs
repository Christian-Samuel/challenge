using System;


namespace API_TakeToGit.Models
{
    public class CardModel
    {
        public string full_name { get; set; }
        public string description { get; set; }
        public DateTimeOffset created_at { get; set; }
        public string language { get; set; }
        public Owner owner { get; set; }
    }
}