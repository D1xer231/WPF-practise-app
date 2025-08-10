using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string fav_meth { get; set; }

        public Users() {}

        public Users(string name, string email, string password, string fav_meth)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.fav_meth = fav_meth;
        }
    }
}
    