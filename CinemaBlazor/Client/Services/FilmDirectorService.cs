using CinemaBlazor.Client.IServices;

namespace CinemaBlazor.Client.Services
{
    public class FilmDirectorService : IFilmDirectorService
    {
        private readonly HttpClient httpClient;

        public FilmDirectorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
