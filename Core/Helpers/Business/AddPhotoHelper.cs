using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Core.Helpers.Business
{
    public class AddPhotoHelper : IAddPhotoHelperService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        // NuGet\Install-Package Microsoft.AspNetCore.Hosting.WindowsServices -Version 8.0.8 packageManager console-da yuklenmelidir(pmc-de Core u seç)
        public AddPhotoHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public void AddImage(IFormFile formFile, string guid)
        {
            var fileName = guid;
            var wwwFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            var imageFolder = Path.Combine(wwwFolder, fileName);
            using var fileStream = new FileStream(imageFolder, FileMode.Create);
            formFile.CopyTo(fileStream);
        }
    }
}
