using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WioShop.Models;
using WioShop.Models.Classes;

namespace WioShop.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Default
        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()      
                {
                    Id = i.Id,
                    ProductName = i.ProductName,
                    ProductDescription = i.ProductDescription.Length > 50 ? i.ProductDescription.Substring(0, 47) + "..." : i.ProductDescription,
                    ProductPrice = i.ProductPrice,
                    ProductImg = i.ProductImg ?? "AT-AT.jpg",
                    Piece = i.Piece,
                    CategoryId = i.CategoryId
                }).ToList();
                return View(urunler);
        }

        public ActionResult About() 
        {
            return View();
        }

        public ActionResult ProductDetails(int id) 
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult Products(int ? id) 
        {
            var urunler = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    ProductName = i.ProductName,
                    ProductDescription = i.ProductDescription.Length > 50 ? i.ProductDescription.Substring(0, 47) + "..." : i.ProductDescription,
                    ProductPrice= i.ProductPrice,
                    ProductImg = i.ProductImg,
                    Piece = i.Piece,
                    CategoryId = i.CategoryId
                }).AsQueryable();

            if(id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }
                return View(urunler.ToList());
        }

        public ActionResult Cargos(int? id)
        {
            var kargolar = _context.Cargos
                .Where(i => i.IsApproved)
                .Select(i => new CargoModel()
                {
                    Id = i.Id,
                    CargoName = i.CargoName,
                    WorkingHours = i.WorkingHours,
                    CargoPrice = i.CargoPrice,
                    CargoImg = i.CargoImg,
                    RegionName = i.RegionName,
                    RegionId = i.RegionId
                }).AsQueryable();

            if (id != null)
            {
                kargolar = kargolar.Where(i => i.RegionId == id);
            }
            return View(kargolar.ToList());
        }

        public PartialViewResult GetCategories ()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}