using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        [Key]
        public int color_id { get; set; }
        public string color_name { get; set; }
    }
}
