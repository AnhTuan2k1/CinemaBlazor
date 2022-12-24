using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CinemaBlazor.Models;
using CinemaBlazor.Services;
using CinemaBlazor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaBlazor.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartRepository cartService;

        public CartController(ICartRepository cartService)
        {
            this.cartService = cartService;
        }
        public IActionResult Index(Cart cart)
        {
           
            cart.UserId = HttpContext.Session.GetString("id");
            
           List<Cart> carts= cartService.GetData2(cart);
            return View(carts);
        }
        
        [Authorize]
        public JsonResult Insert(Movie product)
        { 

            Cart cart = new Cart()
            {
                UserId = HttpContext.Session.GetString("id"),
                MovieId = product.Id,
            };
            var c = cartService.GetData(cart).ToList();
           
            if (c.Count == 0)
            {
                cartService.Insert(cart);
            }
            else
            {
                cartService.Delete(cart);
            }
           
            return Json(true);
        }


    }
}
