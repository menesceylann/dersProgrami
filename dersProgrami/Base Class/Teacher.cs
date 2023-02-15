using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersProgrami.Base_Class
{
    public class Teacher
    {

        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string unvan { get; set; }
        public Gunler[] musaitGunler { get; set; }

        public Teacher(int id, string name, string surname, string unvan, Gunler[] musaitGunler)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.unvan = unvan;
            this.musaitGunler = musaitGunler;
        }

        public Teacher()
        {

        }
    }
}
