using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int product_id { get; set; }
        public int category_id { get; set; }
        public int color_id { get; set; }
        public int brand_id { get; set; }
        public string product_name { get; set; }
        public int product_price { get; set; }
        public string description { get; set; }
        public int stock_quantity { get; set; }
    }
}
