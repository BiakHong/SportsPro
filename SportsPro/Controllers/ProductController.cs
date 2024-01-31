using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SportsPro.Models;
using static SportsPro.Models.ProductList;
using System.Diagnostics.Eventing.Reader;


namespace SportsPro.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductList _context;



        public IActionResult List()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        private ProductList products { get; set; }
        public ProductController(ProductList context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productLis = products.Products.OrderBy(m => m.Name).ToList();
            return View(productLis);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new Product());
        }
        [HttpPost] 
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                return Save(product);
            }
            else
            {
                ViewBag.Action = "Add";
                return View("AddEdit", product);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var product = _context.Products.Find(id);
            return View("AddEdit", product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.Id == 0)
                    _context.Products.Add(product);
                else
                    _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("List", "Product");
            }
            else
            {
                ViewBag.Action = (product.Id == 0) ? "Add" : "Edit";
                return View("AddEdit",product);
            }
        }
        [HttpGet]
        public IActionResult Save(int id)
        {
            ViewBag.Action = "Edit";
            var product = _context.Products.Find(id);
            return View("AddEdit", product);
        }
        [HttpPost]
        public IActionResult Save(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.Id == 0)
                    _context.Products.Add(product);
                else
                    _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("List", "Product");
            }
            else
            {
                ViewBag.Action = (product.Id == 0) ? "Add" : "Edit";
                return View(product);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if(product == null)
            {
                return BadRequest();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("List", "Product");
        }
    }
}