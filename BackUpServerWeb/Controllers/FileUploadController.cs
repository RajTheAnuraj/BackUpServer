using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BackUpServerWeb.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly IConfiguration configuration;

        public FileUploadController(IConfiguration Configuration)
        {
            configuration = Configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload()
        {
            string path = configuration.GetValue<string>("SavePath");
            var files =  Request.Form.Files;
            if(files != null && files.Any()){
                foreach (var file in files)
                {
                    string savePath = $"{path}/{file.FileName}";
                    using var stream = System.IO.File.Create(savePath);
                    file.CopyTo(stream);
                }
            }
            return View("Index");
        }

    }
}
