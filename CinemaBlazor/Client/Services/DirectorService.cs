using CinemaBlazor.Client.IServices;

namespace CinemaBlazor.Client.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly HttpClient httpClient;

        public DirectorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
