using CinemaBlazor.Client.IServices;

namespace CinemaBlazor.Client.Services
{
    public class PromotionService : IPromotionServise
    {
        private readonly HttpClient httpClient;

        public PromotionService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
