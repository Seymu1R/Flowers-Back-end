using Front_to_back_Flowers.Dal;
using Front_to_back_Flowers.Models;
using Front_to_back_Flowers.Modelviews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics;

namespace Front_to_back_Flowers.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _dbcontext;

        public HomeController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        

        public IActionResult Index()
        {
            List<Flower> flowers = _dbcontext.Flowers.Include(fi => fi.FlowerImg).ToList();
            List<FlowerExpert> Fexperts = _dbcontext.FlowerExperts.ToList();
            var marketingsliders = _dbcontext.MarketingSliders.ToList();
            var sliderindexs = _dbcontext.SliderIndexs.ToList().SingleOrDefault();
            var fcategories = _dbcontext.FlowerCategories.ToList();
            var sliderimages = _dbcontext.SliderImages.ToList();
            HomeViewModel viewmodel = new HomeViewModel()
            {
                Flowers = flowers,
                FlowerExperts = Fexperts,
                MarketingSliders = marketingsliders,
                SliderIndex = sliderindexs,
                FlowerCategories = fcategories,
                SliderImages=sliderimages,

            };

            return View(viewmodel);
        }
        public IActionResult ProductList() 
        {
            List<Flower> flowers = _dbcontext.Flowers.Include(fi => fi.FlowerImg).ToList();
            return View(flowers);
        }
        public IActionResult ProductDetail(int id)
        {
            Flower flower = _dbcontext.Flowers.Include(fi=>fi.FlowerImg).FirstOrDefault(fi=>fi.Id==id);
            return View(flower);
        }



    }
       
}