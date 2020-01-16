using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaretBasic.UI.MVC.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}