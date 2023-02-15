using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersProgrami.Base_Class
{
    public class Derslik
    {

        public int id { get; set; }
        public string name { get; set; }
        public DerslikTipi dersTip { get; set; }
        public int kapasite { get; set; }

        public Derslik(int id, string name, DerslikTipi dersTip, int kapasite)
        {
            this.id = id;
            this.name = name;
            this.dersTip = dersTip;
            this.kapasite = kapasite;
        }

        public Derslik()
        {

        }

        public enum DerslikTipi
        {
            Laboratuvar, Derslik
        }
    }
}
