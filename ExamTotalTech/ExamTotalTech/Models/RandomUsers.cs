using Newtonsoft.Json;
using System.Collections.Generic;

namespace ExamTotalTech.Models
{
    public class RandomUsers
    {
        [JsonProperty("results")]

        public List<User> Results { get; set; }
    }
}
