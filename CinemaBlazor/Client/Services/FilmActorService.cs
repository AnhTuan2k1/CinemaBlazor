namespace CinemaBlazor.Client.Services
{
    public class FilmActorService : IFilmActorService
    {
        private readonly HttpClient httpClient;

        public FilmActorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
