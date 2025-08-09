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
        public DateTime created_at { get; set; }
        public string fav_meth { get; set; }

        public Users() {}

        public Users(int id, string name, string email, string password, DateTime created_at, string fav_meth)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.created_at = created_at;
            this.fav_meth = fav_meth;
        }
    }
}
    