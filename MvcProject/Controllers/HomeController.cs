using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using System.Diagnostics;

namespace MvcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IWebHostEnvironment _env { get; set; }
        public HomeController(IWebHostEnvironment env, ILogger<HomeController> logger)
        {
            _logger = logger;
            _env = env;
        }

      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Editer() 
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult UploadImage(List<IFormFile> files)
        {

            var filepath = "";

            foreach (IFormFile photo in Request.Form.Files)
            {
               string serverMapPath = Path.Combine(_env.WebRootPath, "Images", photo.FileName);
               // var serverMapPath = Path.Combine(Directory.GetCurrentDirectory(), "uploads", photo.Name);
                using (var stream = new FileStream(serverMapPath, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }
                filepath = "https://" + HttpContext.Request.Host.Value + "/Images/" + photo.FileName;
            }


            return Json(new { url = filepath });
        }
    }
}
