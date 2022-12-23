using Microsoft.AspNetCore.Http;
using CinemaBlazor.Models;
using CinemaBlazor.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CinemaBlazor.Services
{
    public interface IShowTimeRepository
    {
        int delete(Guid id);
        List<ShowTime> GetAll();
        ShowTimeViewModel GetShowTimeByIdAdmin(Guid id);
        ShowTime GetById(Guid id);
        Task<int> Insert(ShowTimeViewModel newShowTime);
        Task<int> update(ShowTimeViewModel editShowTime, Guid id);
    }
}
