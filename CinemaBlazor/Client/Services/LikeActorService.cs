using CinemaBlazor.Client.IServices;

namespace CinemaBlazor.Client.Services
{
    public class LikeActorService : ILikeActorService
    {
        private readonly HttpClient httpClient;

        public LikeActorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
