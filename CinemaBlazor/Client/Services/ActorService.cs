using CinemaBlazor.Client.IServices;

namespace CinemaBlazor.Client.Services
{
    public class ActorService : IActorService
    {
        private readonly HttpClient httpClient;

        public ActorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
