using CinemaBlazor.Models;
using CinemaBlazor.ViewModels;
using System.Collections.Generic;

namespace CinemaBlazor.Services
{
    public interface ICartRepository
    {
        public List<Cart> GetData(Cart cart);
  
        public void Insert(Cart mic);
        public void Delete(Cart cart);
    }
}
