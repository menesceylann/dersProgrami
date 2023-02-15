using dersProgrami.Base_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersProgrami.Managers
{
    public class GunManager
    {

        static Gunler[] gun = new Gunler[7];

        public GunManager()
        {
            setupGun();
        }

        void setupGun()
        {
            for(int i = 0; i < 7; i++)
            {
                gun[i] = ((Gunler)i);
            }
        }

        public static string DebugClass()
        {
            string str = "";
            foreach(Gunler gun in gun)
            {
                str += gun.ToString() + "\n";
            }
            return str;
        }

        public static Gunler[] initializeGun(string[] gun)
        {
            Gunler[] g = new Gunler[gun.Length];

            for(int i = 0; i < gun.Length; i++)
            {
                switch(gun[i])
                {
                    case "Pazartesi":
                        g[i] = Gunler.Pazartesi;
                        break;
                    case "Salı":
                        g[i] = Gunler.Salı;
                        break;
                    case "Çarşamba":
                        g[i] = Gunler.Çarşamba;
                        break;
                    case "Perşembe":
                        g[i] = Gunler.Perşembe;
                        break;
                    case "Cuma":
                        g[i] = Gunler.Cuma;
                        break;
                    case "Cumartesi":
                        g[i] = Gunler.Cumartesi;
                        break;
                    case "Pazar":
                        g[i] = Gunler.Pazar;
                        break;
                    default:
                        break;
                }
            }
            return g;
        }

        internal static string[] GetGuns(Gunler[] musaitGunler)
        {
            string[] str = new string[musaitGunler.Length];
            for(int i = 0; i < musaitGunler.Length; i++)
            {
                str[i] = musaitGunler[i].ToString();
            }
            return str;
        }
    }
}
