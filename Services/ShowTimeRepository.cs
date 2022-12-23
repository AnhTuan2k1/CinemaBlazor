using Microsoft.AspNetCore.Http;
using CinemaBlazor.Models;
using CinemaBlazor.Services;
using CinemaBlazor.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBlazor.Services
{
    public class ShowTimeRepository : IShowTimeRepository
    {
        public int delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ShowTime> GetAll()
        {
            throw new NotImplementedException();
        }

        public ShowTime GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ShowTimeViewModel GetShowTimeByIdAdmin(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(ShowTimeViewModel newShowTime)
        {
            throw new NotImplementedException();
        }

        public Task<int> update(ShowTimeViewModel editShowTime, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
