using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenProvinceVN.NET
{
    public class Matches
    {
        [JsonProperty("y")]
        public List<int> Y { get; set; }
    }

    public class FindProvince
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("matches")]
        public Matches Matches { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }
}