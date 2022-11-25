using CinemaBlazor.Client.IServices;

namespace CinemaBlazor.Client.Services
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient httpClient;

        public BlogService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
