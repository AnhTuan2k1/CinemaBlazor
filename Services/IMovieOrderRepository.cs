using CinemaBlazor.Models;
using CinemaBlazor.ViewModels;

namespace CinemaBlazor.Services
{
    public interface IMovieOrderRepository
    {

        public void insert(MovieOrder order);
    }
}
