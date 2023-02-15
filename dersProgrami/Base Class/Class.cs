using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersProgrami.Base_Class
{
    public class Class
    {

        public int id { get; set; }
        public string name { get; set; }
        public string dersKod { get; set; }
        public Teacher[] teachers { get; set; }
        public int saat { get; set; }

        public Class(int id, string name, string dersKod, Teacher[] teachers, int saat)
        {
            this.id = id;
            this.name = name;
            this.dersKod = dersKod;
            this.teachers = teachers;
            this.saat = saat;
        }

        public Class()
        {

        }
    }
}
