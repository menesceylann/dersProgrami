using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersProgrami.Base_Class
{
    public class Sube
    {

        public int id { get; set; }
        public string name { get; set; }
        public int dersSaati { get; set; }
        public TimeZone baslangicSaati { get; set; }
        public int tenefusSuresi { get; set; }
        public int ogleTatili { get; set; }
        public Dersler[] dersler { get; set; }

        public Sube(int id, string name, int dersSaati, TimeZone baslangicSaati, int tenefusSuresi, int ogleTatili)
        {
            this.id = id;
            this.name = name;
            this.dersSaati = dersSaati;
            this.baslangicSaati = baslangicSaati;
            this.tenefusSuresi = tenefusSuresi;
            this.ogleTatili = ogleTatili;
        }

        public Sube(int id, string name, int dersSaati, TimeZone baslangicSaati, int tenefusSuresi, int ogleTatili, Dersler[] dersler) : this(id, name, dersSaati, baslangicSaati, tenefusSuresi, ogleTatili)
        {
            this.dersler = dersler;
        }

        public Sube()
        {

        }
    }
}
