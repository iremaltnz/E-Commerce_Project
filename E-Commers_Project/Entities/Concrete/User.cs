using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public byte[] password_hash { get; set; }
        public byte[] password_salt { get; set; }
        public int authority_id { get; set; }
    }
}
