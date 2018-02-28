using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyMVC.Models
{
    [MetadataType(typeof(ProductMD))]
    public partial class Products
    {
       public class ProductMD
        {
            [ScaffoldColumn(false)]
            public int ProductID { get; set; }
            [Required]
            [Display(Name ="產品名稱")]
            public string ProductName { get; set; }


        }
    }
}