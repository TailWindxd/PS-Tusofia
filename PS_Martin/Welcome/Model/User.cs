using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public string Name {get; set; }
        public string Password { get; set; }
        public UserRolesEnum Role { get; set; }

        public User(string Name, string Password, UserRolesEnum Role)
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
        }
    }
}
