using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SD.Data;
using SD.Models;

namespace SD.Controllers
{
    public class ProductController : Controller
    {
        private readonly SDDbContext _context;
        
        public ProductController(SDDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ProductModel> productModels;
            productModels = _context.ProductModels.ToList();
            return View(productModels);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductModel productModel)
        {
            _context.Add(productModel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
