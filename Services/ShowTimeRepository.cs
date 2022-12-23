using Microsoft.AspNetCore.Http;
using CinemaBlazor.Models;
using CinemaBlazor.Services;
using CinemaBlazor.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CinemaBlazor.Services
{
    public class ShowTimeRepository : IShowTimeRepository
    {
        MovieContext db;
        public ShowTimeRepository(MovieContext _db)
        {
            db = _db;
        }

        public int delete(Guid id)
        {
            ShowTime delShowTime = db.ShowTimes.SingleOrDefault(c => c.Id == id);
            db.ShowTimes.Remove(delShowTime);
            int raws = db.SaveChanges();
            return raws;
        }

        public List<ShowTime> GetAll()
        {
            var showtimes = db.ShowTimes.ToList();
            return showtimes;
        }

        public ShowTime GetById(Guid id)
        {
            return db.ShowTimes.SingleOrDefault(c => c.Id == id);
        }

        public ShowTimeViewModel GetShowTimeByIdAdmin(Guid id)
        {
            var showtime = db.ShowTimes.SingleOrDefault(c => c.Id == id);

            ShowTimeViewModel showtimeModel = new ShowTimeViewModel();

            showtimeModel.ProjectionRoom = showtime.ProjectionRoom;
            showtimeModel.StartTime = showtime.StartTime;
            showtimeModel.Tickets = showtime.Tickets;
            showtimeModel.ProjectionRoomId = showtime.ProjectionRoomId;
            showtime.Film = showtime.Film;
            showtimeModel.FilmId = showtime.FilmId;

            return showtimeModel;
        }

        public async Task<int> Insert(ShowTimeViewModel newShowTime)
        {
            var newGuid = Guid.NewGuid();
            db.ShowTimes.Add(new ShowTime()
            {
                Id = newGuid,
                StartTime = newShowTime.StartTime,
                ProjectionRoom = newShowTime.ProjectionRoom,
                ProjectionRoomId = newShowTime.ProjectionRoomId,
                Film = newShowTime.Film,
                FilmId = newShowTime.FilmId,
                Tickets = newShowTime.Tickets,

            });

            return db.SaveChanges();
        }

        public async Task<int> update(ShowTimeViewModel editShowTime, Guid id)
        {
            var showTime = db.ShowTimes.SingleOrDefault(c => c.Id == id);

            showTime.Id = id;
            showTime.ProjectionRoom = editShowTime.ProjectionRoom;
            showTime.StartTime = editShowTime.StartTime;
            showTime.Tickets = editShowTime.Tickets;
            showTime.ProjectionRoomId = editShowTime.ProjectionRoomId;
            showTime.Film = editShowTime.Film;
            showTime.FilmId = editShowTime.FilmId;

            int raws = db.SaveChanges();
            return raws;
        }
    }
}
