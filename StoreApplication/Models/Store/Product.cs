using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreApplication.Models.Store
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please enter product name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Please enter product description")]
        [DataType(DataType.MultilineText)]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Please enter category ")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive value")]
        public decimal Price { get; set; }
        public byte[] ImageData { get; set; }
        public string MimeType { get; set; }

    }
}