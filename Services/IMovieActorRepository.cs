using CinemaBlazor.Models;
using System.Collections.Generic;

namespace CinemaBlazor.Services
{
    public interface IMovieActorRepository
    {
        public List<MovieActor> GetAll();
    }
}
