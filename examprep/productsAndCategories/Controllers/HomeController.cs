using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using productsAndCategories.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace productsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;
        public HomeController(ILogger<HomeController> logger, MyContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        //Products
        [HttpGet("products")]
        public IActionResult Products()
        {
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }

        [HttpPost("addProduct")]
        public IActionResult addProduct(Product newProduct)
        {
            ViewBag.AllProducts = _context.Products.ToList();
            if(ModelState.IsValid)
            {
                if(_context.Products.Any(p => p.Name == newProduct.Name))
                {
                    ModelState.AddModelError("Name", "Product Name already exists");
                    return View("Products");
                }
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("products");
            } else {
                return View("Products");
            }
        }

        [HttpGet("product/{pid}")]
        public IActionResult OneProduct(int pid)
        {
            Product OneProduct = _context.Products
            .Include(p => p.Categories)
                .ThenInclude(p => p.Category)
            .FirstOrDefault(p => p.ProductId == pid);
            ViewBag.CategoriesNotInProduct = _context.Categories
            .Include(p => p.Products)
                .ThenInclude(p => p.Product);
            ViewBag.CategoriesOfProduct = _context.Products
            .Include(p => p.Categories)
                .ThenInclude(p => p.Category)
            .FirstOrDefault(p => p.ProductId == pid);

            return View(OneProduct);
        }

        [HttpPost("addToCategory")]
        public IActionResult addToCategory(Association newCat)
        {
            _context.Associations.Add(newCat);
            _context.SaveChanges();
            return Redirect($"product/{newCat.ProductId}");
        }

        //Categories
        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.allCategories = _context.Categories.ToList();
            return View();
        }

        [HttpPost("addCategory")]
        public IActionResult addCategory(Category newCategory)
        {
            ViewBag.allCategories = _context.Categories.ToList();
            if(ModelState.IsValid){
                if(_context.Categories.Any(p => p.Name == newCategory.Name))
                {
                    ModelState.AddModelError("Name", "Category already exists");
                    return View("Categories");
                }
                _context.Categories.Add(newCategory);
                _context.SaveChanges();
                return RedirectToAction("categories");
            } else {
                return View("Categories");
            }
        }

        [HttpGet("/{cid}")]
        public IActionResult Index(int cid)
        {
            Category OneCategory = _context.Categories
            .Include(p => p.Products)
                .ThenInclude(p => p.Product)
                .FirstOrDefault(p => p.CategoryId == cid);
            ViewBag.ProductsNotInCategory = _context.Products
            .Include(p => p.Categories)
                .ThenInclude(p => p.Category)
            .Where(p => p.ProductId != cid);
            ViewBag.ProductsInCategory = _context.Categories
            .Include(p => p.Products)
                .ThenInclude(p => p.Product)
            .FirstOrDefault(p => p.CategoryId == cid);

            return View(OneCategory);
        }
        
        [HttpPost("addProductTo")]
        public IActionResult addProductTo(Association newProd)
        {
            _context.Associations.Add(newProd);
            _context.SaveChanges();
            return Redirect($"/{newProd.CategoryId}");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
