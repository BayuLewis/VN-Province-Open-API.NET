using RestSharp;
using static OpenProvinceVN.NET.Constants;

namespace OpenProvinceVN.NET
{
    public partial class OpenProvinceAPI
    {
        private readonly RestClient Client;
        public OpenProvinceAPI()
        {
            Client = new RestClient(BASE_URL);
        }
    }
}