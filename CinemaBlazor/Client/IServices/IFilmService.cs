using CinemaBlazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBlazor.Client.IServices
{
    public interface IFilmService
    {
        Task<IEnumerable<Film>?> GetFilms();
    }
}
