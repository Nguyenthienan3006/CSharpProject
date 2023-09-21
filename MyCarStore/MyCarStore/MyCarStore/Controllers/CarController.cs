using Microsoft.AspNetCore.Mvc;
using MyCarStore.Models;
using System.Web;

namespace MyCarStore.Controllers
{
    public class CarController : Controller
    {
        public ActionResult Index()
        {
            //Tao một list chứa danh sách các ô tô 
            List<Car> cars = new List<Car>()
            {
                new Car { Id = 1, Name="Audi A8", Description="Expensive Car", Price = 100 },
                new Car { Id = 2, Name="Kia Morning", Description="Cheap Car", Price = 20 },
                new Car { Id = 3, Name="Lamboghini Aventador", Description="Super Car", Price = 500 },
                new Car { Id = 4, Name="Roll Royces", Description="Super Car", Price = 400 },
            };
            return View(cars);
        }


        public string AboutUs(string name, int age)
        {
            return HttpUtility.HtmlEncode("Hello, I am " + name + ".  I am " + age + " years old.");
        }

    }
}
