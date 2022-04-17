using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy_ASP_Net.Data;
using Udemy_ASP_Net.Models;
using Udemy_ASP_Net.Utility;

namespace Udemy_ASP_Net.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _db;
        
        public CartController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            if(HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart)!=null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count()>0)
            {
                shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
            }

            List<int> prodInCart = shoppingCartList.Select(i => i.ProductId).ToList();
            IEnumerable<Product> productList = _db.Product.Where(u => prodInCart.Contains(u.Id));

            return View(productList);
        }

        public IActionResult Remove(int id)
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
            }

            shoppingCartList.Remove(shoppingCartList.FirstOrDefault(u => u.ProductId == id));

            List<int> prodInCart = shoppingCartList.Select(i => i.ProductId).ToList();
            HttpContext.Session.Set(WC.SessionCart, shoppingCartList);
            IEnumerable<Product> productList = _db.Product.Where(u => prodInCart.Contains(u.Id));

            return RedirectToAction(nameof(Index));
        }
    }
}
