using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.AspNetCore.Mvc;
using ZXing;
using ZXing.Common;
using BarCodeMVC.Models;

namespace BarCodeMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult CreateBarcode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBarcode(GenerateBarcodeModel generateBarcode)
        {
            try
            {
                var writer = new BarcodeWriterPixelData
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new EncodingOptions
                    {
                        Width = 500,
                        Height = 120,
                        Margin = 1
                    }
                };

                var pixelData = writer.Write(generateBarcode.BarcodeText);

                using (var bitmap = new Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppRgb))
                {
                    var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height),
                        ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
                    try
                    {
                        // Copy pixel data to bitmap
                        System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0,
                            pixelData.Pixels.Length);
                    }
                    finally
                    {
                        bitmap.UnlockBits(bitmapData);
                    }

                    string folderPath = Path.Combine(_environment.WebRootPath, "GeneratedBarcode");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string filePath = Path.Combine(folderPath, "barcode.png");
                    bitmap.Save(filePath, ImageFormat.Png);

                    string imageUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}/GeneratedBarcode/barcode.png";
                    ViewBag.QrCodeUri = imageUrl;
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }

            return View();
        }
    }
}
