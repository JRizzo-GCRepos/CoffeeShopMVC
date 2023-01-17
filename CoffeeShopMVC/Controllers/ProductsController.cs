using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShopMVC.Models;

namespace CoffeeShopMVC.Controllers
{
    public class ProductsController : Controller
    {
        List<ProductsViewModel> _products;
        

        public ProductsController()
        {
            _products = new List<ProductsViewModel>();

            ProductsViewModel ProductOne = new ProductsViewModel()
            {
                Id = 1,
                Name = "Coffee",
                Description = "Plain Black Coffee",
                Price = 3.25,
                Category = "Classics"

            };
            ProductsViewModel ProductTwo = new ProductsViewModel()
            {
                Id = 2,
                Name = "Space Cowboy",
                Description = "Our special space dust mix on top of whipped cream with a machiatto base",
                Price = 5.50,
                Category = "Specialty",

            };
            ProductsViewModel ProductThree = new ProductsViewModel()
            {
                Id = 3,
                Name = "Coffee with Cream and Sugar",
                Description = "Our Classic Black Coffee With your desired amount of cream and sugar",
                Price = 4.50,
                Category = "Classics"

            };
            ProductsViewModel ProductFour = new ProductsViewModel()
            {
                Id = 4,
                Name = "Cow Tipper",
                Description = "Espresso and Mocha Coffee with a flourish of steamed whole milk",
                Price = 5.50,
                Category = "Specialty"

            };
            ProductsViewModel ProductFive = new ProductsViewModel()
            {
                Id = 5,
                Name = "Wrong Side of the Bed",
                Description = "The Maximum Amount of Shots of Espresso Legally allowed with a Hazelnut Coffee and peanut butter drizzle, whip cream optional",
                Price = 7.50,
                Category = "Specialty"

            };
            ProductsViewModel ProductSix = new ProductsViewModel()
            {
                Id = 6,
                Name = "Hot Chocolate",
                Description = "Classic Hot Chocolate with Marshmellows upon request",
                Price = 3.50,
                Category = "Classics"

            };

            _products.Add(ProductOne);
            _products.Add(ProductTwo);
            _products.Add(ProductThree);
            _products.Add(ProductFour);
            _products.Add(ProductFive);
            _products.Add(ProductSix);
        }

        

    
        // GET: ProductController
        public ActionResult Index()
        {
            
            return View(_products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {

            ProductsViewModel product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
