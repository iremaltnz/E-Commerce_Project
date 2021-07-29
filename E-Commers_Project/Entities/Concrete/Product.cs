using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }    
    }
}
