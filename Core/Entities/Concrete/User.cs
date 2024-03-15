using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class User :IEntity
    {
        public int UserID { get; set; }
        public int RolID {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TCNo {  get; set; }
        public string PhoneNumber {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
