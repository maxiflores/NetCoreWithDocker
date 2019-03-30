using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
    public class ProductosViewModel
    {
        public string name { get; set; }
        public string price { get; set; }
    }

    public class ListProducts
    {
       public List<ProductosViewModel> products { get; set; }
    }
}
