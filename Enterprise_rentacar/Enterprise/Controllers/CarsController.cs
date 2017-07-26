using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Enterprise.Models;
using System.Web.Mvc;
using Enterprise.ViewModels;

namespace Enterprise.Controllers
{
    public class CarsController : Controller
    {



        public ViewResult Index()
        {
            var cars = GetCars();
            return View(cars);
        }

        public IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car {Id = 1, Name = "Civic" },
                new Car {Id = 2, Name = "Accord" }
            };
        }
        // GET: Cars/random
        public ActionResult Random()
        {
            Car car = new Car() { Name = "civic" };

            var Customers = new List<Customer>()
            {
                new Customer {Name = "Customer1" },
                new Customer {Name = "customer2" }
            };
            var viewmodel = new RandomCarViewModel()
            {
                Car = car,
                Customers = Customers

            };
            return View(viewmodel);

        }

    }
}