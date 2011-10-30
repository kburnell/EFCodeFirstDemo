using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using EFCodeFirst.DataContext;
using EFCodeFirst.Models;
using EFCodeFirst.Web.Models;
using EFCodeFirst.Web.Util;
using EFCodeFirst.Web.ViewModels;

namespace EFCodeFirst.Web.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            Database.SetInitializer(new TestDataContextInitializer());
            DataContext.DataContext dc = new DataContext.DataContext();
            IList<Manufacturer> manufacturers = dc.Manufacturers.ToList();
            ViewBag.Message = "EFCodeFirst - Working With MVC4";
            IList<SpatialModel> spatials = new List<SpatialModel>();
            spatials.Add(new SpatialModel { SpatialText = string.Format("Ferrari is {0} miles from Lamborghini.", Math.Round(manufacturers[0].Location.Distance(manufacturers[1].Location) / 1609.344, 2)) });
            spatials.Add(new SpatialModel { SpatialText = string.Format("Lamborghini is {0} miles from Aston Martin.", Math.Round(manufacturers[1].Location.Distance(manufacturers[2].Location) / 1609.344, 2)) });
            return View(new EFCodeFirstViewModel{Manufacturers = manufacturers, Spatials = spatials});
        }

        public ActionResult AddManufacturer() {
            return View(new Manufacturer());
        }

        public ActionResult Spatial() {
            IList<Manufacturer> manufacturers = DataGenerator.GetManufacturers();
            IList<SpatialModel> model = new List<SpatialModel>();
            model.Add(new SpatialModel {SpatialText = string.Format("Ferrari is {0} miles from Lamborghini.", Math.Round(manufacturers[0].Location.Distance(manufacturers[1].Location)/1609.344, 2))});
            model.Add(new SpatialModel {SpatialText = string.Format("Lamborghini is {0} miles from Aston Martin.", Math.Round(manufacturers[1].Location.Distance(manufacturers[2].Location)/1609.344, 2))});
            return View(model);
        }

        public ActionResult About() {
            ViewBag.Message = "Your quintessential app description page.";
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your quintessential contact page.";
            return View();
        }
    }
}