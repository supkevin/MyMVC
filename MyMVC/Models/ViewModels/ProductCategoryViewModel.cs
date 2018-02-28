using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models.ViewModels
{
    public class ProductCategoryViewModel
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public IEnumerable<Products> Product { get; set; }
        public IEnumerable<Categories> Category { get; set; }
    }
}