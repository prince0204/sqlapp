using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using sqlapp.Models;
using sqlapp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sqlapp.Pages
{
    public class IndexModel : PageModel
    {

        public List<Product> Products;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();
        }
    }
}
