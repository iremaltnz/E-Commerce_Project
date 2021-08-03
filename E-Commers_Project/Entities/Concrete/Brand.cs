using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        [Key]
        public int brand_id { get; set; }
        public string brand_name { get; set; }
    }
}
