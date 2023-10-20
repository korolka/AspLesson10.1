using AspLesson10._1.Models;
using AspLesson10._1.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspLesson10._1.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration configuration;
        IWorkerCount count;
        ITimeNow time;
        public HomeController(IWorkerCount count, IConfiguration configuration, ITimeNow time)
        {
            this.count = count;
            this.configuration = configuration;
            this.time = time;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ex0()
        {
            SomeCompany res = count.Count(configuration);
            return View(res);
        }

        public IActionResult Ex1()
        {
            MyInfo info = configuration.GetSection("MyData").Get<MyInfo>();           
                return View(info);
        }

        public IActionResult Ex2()
        {
            string timeNow = time.Time();
            return View(timeNow as object);
        }
    }
}
