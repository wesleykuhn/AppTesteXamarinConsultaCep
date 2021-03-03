using System.Net;
using System.Threading.Tasks;
using AppConsultaCep.Library.Models;
using Newtonsoft.Json;

namespace AppConsultaCep.Library
{
    public static class HttpRequest
    {
        private static string uri = "http://viacep.com.br/ws/{0}/json";

        public static async Task<Endereco> SeekEnderecoUsingCEPAsync(string cep)
        {
            string uriToSeek = string.Format(uri, cep);

            WebClient wc = new WebClient();

            string result = await wc.DownloadStringTaskAsync(uriToSeek);

            return JsonConvert.DeserializeObject<Endereco>(result);
        }
    }
}
