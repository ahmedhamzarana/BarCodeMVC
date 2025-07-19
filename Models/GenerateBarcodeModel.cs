using System.ComponentModel.DataAnnotations;

namespace BarCodeMVC.Models
{
    public class GenerateBarcodeModel
    {

        [Display(Name = "Enter Barcode Text")]
        [Required]
        public string BarcodeText { get; set; }
    }
}
