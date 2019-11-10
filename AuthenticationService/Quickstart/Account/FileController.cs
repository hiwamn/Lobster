using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NikoCore;

namespace IdentityServer4.Quickstart.UI
{
    public class FileController : Controller
    {
        
        public FileController()
        {
            
        }

        [HttpPost]
        public async Task<IActionResult> AsyncUploadPicture(string forWhat)
        {
            var files = Request.Form.Files[0];
            if (!files.ContentType.Contains("image"))
                return new StatusCodeResult(403);

            using (var ms = new MemoryStream())
            {
                files.CopyTo(ms);
                var fileBytes = ms.ToArray();
                string s = Convert.ToBase64String(fileBytes);

                var id = Api.ToObject<Inputs>(Api.Execute(new Inputs { ForWhat = forWhat, FileType = 1, File = fileBytes }, "SendFile")).Guid;
                return new OkObjectResult(new { id = id });
            }
        }

    }
}