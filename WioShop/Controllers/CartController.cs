using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WioShop.Models.Classes;

namespace WioShop.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }

        public ActionResult SepeteEkle(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);
            if (product != null)
            {
                GetCart().UrunEkle(product, 1);
            }
            return RedirectToAction("Index");
        }

        public ActionResult UrunSil(int Id)
        {

            var product = db.Products.FirstOrDefault(i => i.Id == Id);
            if (product != null)
            {
                GetCart().UrunSil (product);
            }
            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            var cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }


        public PartialViewResult SepetOzet()
        {
            return PartialView(GetCart());
        }


        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }


        [HttpPost]
        public ActionResult Checkout(ShippingDetails entity)
        {

            var cart = GetCart();
            if (cart.CartLines.Count == 0)
            {
                ModelState.AddModelError("UrunYokError", "Sepetinizde ürün bulunmamaktır.");
            }


            if (ModelState.IsValid)
            {

                SaveOrder(cart, entity);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(entity);

            }
        }

        private void SaveOrder(Cart cart, ShippingDetails entity)
        {
            var order = new Order();

            order.OrderNumber = "K" + (new Random()).Next(11111, 99999).ToString();
            order.Tutar = cart.Tutar();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Bekliyor;
            order.UserName = User.Identity.Name;
            order.AdresBasligi = entity.AdresBasligi;
            order.Adres = entity.Adres;
            order.Sehir = entity.Sehir;
            order.Semt = entity.Semt;
            order.Mahalle = entity.Mahalle;
            order.PostaKodu = entity.PostaKodu;

            order.Orderlines = new List<OrderLine>();
            foreach (var pr in cart.CartLines)
            {
                var orderline = new OrderLine();
                orderline.Miktar = pr.Number;
                orderline.Price = pr.Number * pr.Product.ProductPrice;
                orderline.ProductId = pr.Product.Id;

                order.Orderlines.Add(orderline);
            }
            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
    }