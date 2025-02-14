using Apitest.Repository;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;
namespace Apitest.Repository
{
    public class UserRepository : IUserRepository
    {

        //using HttpClient client = new HttpClient();

        private readonly HttpClient _httpClient;
        public UserRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<object> getApi()
        {
            //using HttpClient client = new HttpClient();
            string url = "https://65f983b3df1514524611d7db.mockapi.io/deep/users";
            var result = await _httpClient.GetAsync(url);

           
            return result.Content.ReadAsStringAsync();
            //return await _httpClient.GetStringAsync("https://65f983b3df1514524611d7db.mockapi.io/deep/users");
        }
    }
    }
