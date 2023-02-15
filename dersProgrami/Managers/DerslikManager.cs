using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dersProgrami.Base_Class;
using System.IO;

namespace dersProgrami.Managers
{
    public class DerslikManager
    {

        protected static LinkedList<Derslik> list = new LinkedList<Derslik>();


        public DerslikManager()
        {
            loadFile();
        }

        void loadFile()
        {
            foreach(FileInfo f in new DirectoryInfo(Environment.CurrentDirectory + "\\Derslik").GetFiles())
            {
                IniFile file = new IniFile(f.FullName);
                Derslik d = new Derslik();
                d.id = int.Parse(f.Name.Substring(0, f.Name.Length - 4));
                d.name = file.Read("name");
                d.dersTip = file.Read("type").Equals("Derslik") ? Derslik.DerslikTipi.Derslik : Derslik.DerslikTipi.Laboratuvar;
                d.kapasite = int.Parse(file.Read("kapasite"));
                list.AddLast(d);
            }
        }

        public static void addDerslik(Derslik d)
        {
            list.AddLast(d);
        }

        public static void removeDerslik(Derslik d)
        {
            list.Remove(d);
        }

        public static Derslik getDerslik(int id)
        {
            foreach(Derslik d in list)
            {
                if(d.id == id)
                {
                    return d;
                }
            }
            return null;
        }

        public static Derslik[] GetAllClass()
        {
            return list.ToArray();
        }

        public static void Save()
        {
            foreach(Derslik s in list)
            {
                IniFile file = new IniFile(Environment.CurrentDirectory + "\\Derslik\\" + s.id.ToString() + ".ini" );
                file.Write("name", s.name);
                file.Write("type", s.dersTip.ToString());
                file.Write("kapasite", s.kapasite.ToString());
                
            }
        }

        public static void SetDerslik(int id, Derslik d)
        {
            foreach(Derslik de in list)
            {
                if(de.id == id)
                {
                    list.Remove(de);
                    break;
                }
            }
            list.AddLast(d);
        }

    }
}
