using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Authority : IEntity
    {
        [Key]
        public int authority_id { get; set; }
        public string authority_name { get; set; }
    }
}
