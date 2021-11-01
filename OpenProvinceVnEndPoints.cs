using System.Threading.Tasks;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using static OpenProvinceVN.NET.Constants;
using OpenProvinceVN.NET.Models;

namespace OpenProvinceVN.NET
{
    public partial class OpenProvinceAPI
    {
        public async Task<List<Province>> GetProvinceList(int depth)
        {
            var request = new RestRequest(API, DataFormat.Json).AddParameter( "depth", depth);
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if(!response.IsSuccessful) throw new Exception($"Error: {response.StatusCode} {response.StatusDescription} {response.ResponseUri}");
            return JsonConvert.DeserializeObject<List<Province>>(content);
        }

        public async Task<List<FindProvince>> FindProvince(string q)
        {
            var request = new RestRequest(SEARCH, DataFormat.Json).AddParameter( "q",q);
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if(!response.IsSuccessful) throw new Exception($"Error: {response.StatusCode} {response.StatusDescription} {response.ResponseUri}");
            return JsonConvert.DeserializeObject<List<FindProvince>>(content);
        }
    }
}