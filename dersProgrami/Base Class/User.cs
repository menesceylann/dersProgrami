using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersProgrami.Base_Class
{
    public class User
    {

        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string yetki { get; set; }

        public User(int id, string username, string password, string yetki)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.yetki = yetki;
        }
        public User()
        {

        }
    }
}
