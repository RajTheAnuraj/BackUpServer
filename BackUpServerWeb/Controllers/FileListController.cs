using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BackUpServerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BackUpServerWeb.Controllers
{
    public class FileListController : Controller
    {
        private readonly IConfiguration configuration;

        public FileListController(IConfiguration Configuration)
        {
            configuration = Configuration;
        }

        public IActionResult Index()
        {
            string savePath = configuration.GetValue<string>("SavePath");
            DirectoryInfo di = new DirectoryInfo(savePath);
            var files = di.GetFiles();
            List<FileDetail> fileDetails = new List<FileDetail>();
            foreach (var file in files)
            {
                fileDetails.Add(
                    new FileDetail { FileName = file.Name, FilePath = file.FullName }
                    );
            }

            ViewData.Add("fileDetails", fileDetails);
            return View();
        }

        public IActionResult GetFile(string key)
        {
            string path = configuration.GetValue<string>("SavePath");
            string savePath = Path.Join(path, key);
            byte[] arr = System.IO.File.ReadAllBytes(savePath);
            return File(arr, System.Net.Mime.MediaTypeNames.Application.Octet, key);
        }


    }
}
