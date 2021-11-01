
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenProvinceVN.NET.Models
{
    public class District
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("codename")]
        public string Codename { get; set; }

        [JsonProperty("division_type")]
        public string DivisionType { get; set; }

        [JsonProperty("province_code")]
        public int ProvinceCode { get; set; }

        [JsonProperty("wards")]
        public object Wards { get; set; }
    }

    public class Province
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("division_type")]
        public string DivisionType { get; set; }

        [JsonProperty("phone_code")]
        public int PhoneCode { get; set; }

        [JsonProperty("codename")]
        public string Codename { get; set; }

        [JsonProperty("districts")]
        public List<District> Districts { get; set; }
    }
}