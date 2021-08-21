using Entities.Concrete;

namespace Entities.DTOs
{
  public  class UserForLoginDto:IDto
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
