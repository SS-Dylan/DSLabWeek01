using DSLabWeek01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace DSLabWeek01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        #region Simple Types
        public IActionResult SimpleTypes()
        {
            bool b = true;
            sbyte sb = -128;
            decimal d = 1.34M;
            float f =4.56F;
            uint ui = 32768;
            short s = 32767;

            return Content($"My name is Dylan. My values: {b}, {sb}, {d}, {f}, {ui}, {s}");
        }
        #endregion

        #region Toy Array
        public IActionResult Toys()
        {
            Toy[] toys = new Toy[3];
            toys[0] = new Toy { Id = 1, Brand = "Lego", Description = "Architecture France" };
            toys[1] = new Toy { Id = 2, Brand = "Lego", Description = "Porsche 911" };
            toys[2] = new Toy { Id = 3, Brand = "Hotwheels", Description = "Subaru Impreza WRX STi" };
            return View(toys);
        }
        #endregion

        #region Student Details
        public IActionResult StudentDetails(string Name, LetterGrade Grade)
        {
            Student student = new Student { Name = "Dylan", Grade = LetterGrade.A };
            return View(student);
        }
        #endregion

        #region LambdaDemo
        public IActionResult LambdaDemo()
        {
            Product[] products = new Product[]
            {
                new Product { Id = 1, Name = "Handkerchief", Color = "Red", Price = 1.30M },
                new Product { Id = 2, Name = "Chair", Color = "Blue", Price = 2.45M },
                new Product { Id = 3, Name = "Towel", Color = "Pink", Price = 0.89M }
            };

            var lowest = products.Min(p => p.Price);

            return View(lowest);
        }
        #endregion

        #region Create Student
        public IActionResult CreateStudent()
        {
            return View();
        }
        #endregion

        #region Student Details HttpPost
        [HttpPost]
        public IActionResult StudentDetails(Student student)
        {
            return View(student);
        }
        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}