using Entities.Concrete;

namespace Entities.DTOs
{
   public class UserForRegisterDto : IDto
    {
        public string email { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public int authority_id { get; set; }

    }
}
