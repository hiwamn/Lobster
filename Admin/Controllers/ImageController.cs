using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Domain.Contract;
using Domain.Entities;
using Utility;
using Utility.Firebase;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Utility.SiteConstants;

namespace Admin.Contollers
{
    public class ImageController : Controller
    {
        private IUnitOfWork unit;
        private readonly IHostingEnvironment hosting;

        public ImageController(IUnitOfWork _unit,IHostingEnvironment hosting)
        {
            unit = _unit;
            this.hosting = hosting;
        }
        [HttpGet]
        public async Task<IActionResult> GetImage(Guid Id)
        {
            var image = unit.Image.Get(Id);
            return PhysicalFile(hosting.WebRootPath + "\\AppImages\\" + Path.GetFileName(image.Location), "image/jpeg");
        }

        [HttpPost]
        public string SendImage()
        {
            var file = Request.Form.Files[0];
            Guid guid = SaveImage(file);
            return Api.ToJson(new { Images = guid.ToString() });
        }       
        [HttpPost]
        public string SendImages()
        {
            List<Guid> list = new List<Guid>();
            Request.Form.Files.ToList().ForEach(p =>
            {
                var guid = SaveImage(p);
                list.Add(guid);
            });
            return Api.ToJson(new { Images = list });
        }

        private Guid SaveImage(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);

            Guid guid = Guid.NewGuid();
            string fileName = guid.ToString() + extension;
            var HardLocation = hosting.WebRootPath + "/AppImages" + $"/{fileName}";
            var HostLocation = PanelData.Root + "/AppImages" + $"/{fileName}";


            if (file.Length > 0)
            {
                using (var fileStream = new FileStream(HardLocation, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }

            Image img = new Image
            {
                Id = guid,
                Location = HostLocation,
                RegisterDate = DateTime.Now.ToUnix()
            };
            unit.Image.Add(img);
            unit.Complete();
            return guid;
        }
    }
}
