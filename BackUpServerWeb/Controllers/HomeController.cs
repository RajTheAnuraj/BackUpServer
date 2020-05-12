using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackUpServerWeb.Models;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;

namespace BackUpServerWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration Configuration)
        {
            _logger = logger;
            configuration = Configuration;
        }

        public IActionResult Index()
        {
            string savePath = configuration.GetValue<string>("SavePath");
            DirectoryInfo di = new DirectoryInfo(savePath);
            var files = di.GetFiles();
            List<FileDetail> fileDetails = new List<FileDetail>();
            foreach(var file in files)
            {
                fileDetails.Add(
                    new FileDetail { FileName = file.Name, FilePath = file.FullName }
                    );
            }

            ViewData.Add("fileDetails", fileDetails);
            return View();
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public IActionResult Upload(IFormFile file)
        {
            string path = configuration.GetValue<string>("SavePath");
            string savePath = $"{path}/{file.FileName}";
            using var stream = System.IO.File.Create(savePath);
            file.CopyTo(stream);
            return View("Index");
        }


        public IActionResult GetFile(string key)
        {
            string path = configuration.GetValue<string>("SavePath");
            string savePath = $"{path}/{key}";
            byte[] arr = System.IO.File.ReadAllBytes(savePath);
            return File(arr, System.Net.Mime.MediaTypeNames.Application.Octet, key);
        }
    }
}
