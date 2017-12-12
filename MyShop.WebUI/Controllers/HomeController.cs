using MyShop.Core.Contracts;
using MyShop.Core.Models;
using MyShop.Core.ViewMoldels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Product> context;
        IRepository<ProductCategory> productCategories;

        public HomeController(IRepository<Product> productContext, IRepository<ProductCategory> productCategoryRepository)
        {
            context = productContext;
            productCategories = productCategoryRepository;
        }

        public ActionResult Index(string category = null)
        {
            List<Product> products = context.Collection().ToList();
            List<ProductCategory> productCategory = productCategories.Collection().ToList();

            if (category == null)
            {
                products = context.Collection().ToList();
            }
            else
            {
                products = context.Collection().Where(p => p.Category == category).ToList();
            }

            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Product = products;
            viewModel.ProductCategories = productCategory;

            return View(viewModel);
        }

        public ActionResult Details(string Id)
        {
            Product product = context.Find(Id);

            if (product == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(product);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}