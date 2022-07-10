using sqlapp.Models;
using System.Collections.Generic;

namespace sqlapp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}