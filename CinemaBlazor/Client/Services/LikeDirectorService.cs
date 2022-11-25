using CinemaBlazor.Client.IServices;

namespace CinemaBlazor.Client.Services
{
    public class LikeDirectorService : ILikeDirectorService
    {
        private readonly HttpClient httpClient;

        public LikeDirectorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
