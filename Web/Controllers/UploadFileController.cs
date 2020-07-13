using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading;
using Microsoft.AspNetCore.Cors;

namespace Web.Controllers
{
    public class UploadModel
    {
        public IFormFile xFile { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class UploadFileController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Content("OK");
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            // Console.WriteLine(xfile.FileName);
            // String path = $@"./${xfile.FileName}";
            // using (var stream = new MemoryStream())
            // {
            //     await xfile.CopyToAsync(stream);
            // }
            return Ok();
        }
    }
}