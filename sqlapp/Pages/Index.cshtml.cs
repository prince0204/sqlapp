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

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }
        public void OnGet()
        {
            Products = _productService.GetProducts();
        }
    }
}
