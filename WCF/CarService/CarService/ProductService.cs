using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    class ProductService : IProduct
    {
        public string GetCategoryName()
        {
            return "Toyota GT86";
        }

        public string GetProductName()
        {
            return "Sea gray";
        }

        public string GetProductQty()
        {
            return "1";
        }
    }
}
