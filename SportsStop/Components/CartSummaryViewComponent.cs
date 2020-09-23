using Microsoft.AspNetCore.Mvc;
using SportsStop.Models;

namespace SportsStop.Components
{
   public class CartSummaryViewComponent : ViewComponent
   {
       private Cart cart;
       public CartSummaryViewComponent(Cart cartService)
       {
           cart = cartService;
       }
       public IViewComponentResult Invoke()
       {
           return View(cart);

       }
   }
}   
