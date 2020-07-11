using AuthApplication.Data;
using AuthApplication.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApplication.Services
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AuthDBContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        
        public UnitOfWork(AuthDBContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
          
        }

        public async void UploadImage(IFormFile file)
        {
            long totalBytes = file.Length;
            string fileName = file.FileName.Trim('"');

            using (var fileStream = new FileStream(GetPathAndFileName(fileName), FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            fileName = EnsureFileName(fileName);
            byte[] buffer = new byte [16 * 1024];
            using (FileStream Output = System.IO.File.Create(GetPathAndFileName(fileName)))
            {
                
                using (Stream Input = file.OpenReadStream())
                {
                    int readBytes;
                    while ((readBytes = Input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        
                        await Output.WriteAsync(buffer, 0, readBytes);
                        totalBytes += readBytes;
                    }
                }
            }
        }

        private string GetPathAndFileName(string fileName)
        {
            string srcPath = hostingEnvironment.WebRootPath + "\\images\\";
            if (!Directory.Exists(srcPath))
            {
                Directory.CreateDirectory(srcPath);
            }
            string curfile = srcPath + fileName;
            return curfile;
        }

        private string EnsureFileName(string fileName)
        {
            if (fileName.Contains("\\"))
                fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            
            return fileName;
        }
    }
}
