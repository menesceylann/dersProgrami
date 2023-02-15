using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dersProgrami.Base_Class;

namespace dersProgrami.Managers
{
    public class OgretmenManager
    {

        protected static LinkedList<Teacher> list = new LinkedList<Teacher>();


        public OgretmenManager()
        {
            loadFile();
        }

        void loadFile()
        {
            foreach (FileInfo info in new DirectoryInfo(Environment.CurrentDirectory + "\\Teachers").GetFiles())
            {
                IniFile file = new IniFile(info.FullName);
                Teacher t = new Teacher();
                t.id = int.Parse(info.Name.Substring(0, info.Name.Length - 4));
                t.name = file.Read("name");
                t.surname = file.Read("surname");
                t.unvan = file.Read("unvan");
                t.musaitGunler = GunManager.initializeGun(file.Read("gunler").Split(','));
                list.AddLast(t);
            }
            GC.Collect();
        }

        public static void addOgretmen(Teacher ogr)
        {
            list.AddLast(ogr);
        }

        public static void removeOgretmen(Teacher ogr)
        {
            list.Remove(ogr);
            File.Delete(Environment.CurrentDirectory + "\\Teachers\\" + ogr.id.ToString() + ".ini");
        }

        public static string[] GetTeacherNameWithId(Teacher[] t)
        {
            string [] names = new string[t.Length];
            for(int i = 0; i < t.Length; i++)
            {
                names[i] = t[i].name;
            }
            return names;
        }

        public static string DebugClass()
        {
            string str = "";
            foreach(Teacher t in list)
            {
                str += t.id + " - " + t.name + " - " + t.surname + " - " + t.unvan + " - " + t.musaitGunler.ToString() + "\n";
            }
            return str;
        }

        public static Teacher[] GetAll()
        {
            return list.ToArray();
        }

        public static string[] GetAllOgretmenAdi()
        {
            string[] str = new string[list.Count];
            int sayi = 0;

            foreach(Teacher teacher in list)
            {
                str[sayi] = teacher.name;
                sayi++;
            }

            return str;
        }

        public static Teacher[] initializeOgretmen(string[] ogretmen) {

            Teacher[] t = new Teacher[ogretmen.Length];
            for(int i = 0; i < ogretmen.Length; i++)
            {
                t[i] = GetTeacher(int.Parse(ogretmen[i]));
            }

            return t;

        }

        public static Teacher[] initializeOgretmenId(string[] id)
        {
            Teacher[] t = new Teacher[id.Length];



            return t;
        }

        public static Teacher GetTeacher(int id)
        {
            foreach(Teacher t in list)
            {
                if (t.id == id)
                    return t;
            }
            return null;
        }



        public static void Save()
        {

            foreach(Teacher t in list)
            {
                IniFile file = new IniFile(Environment.CurrentDirectory + "\\Teachers\\" + t.id.ToString() + ".ini");
                file.Write("name", t.name);
                file.Write("surname", t.surname);
                file.Write("unvan", t.unvan);
                string s = "";
                foreach(Gunler g in t.musaitGunler)
                {
                    s += g.ToString() + ",";
                }
                s = s.Substring(0, s.Length - 1);
                file.Write("gunler", s);
            }

            /*
            for (int i = 0; i < bunifuDataGridView1.Rows.Count; i++)
            {
                IniFile file = new IniFile(Environment.CurrentDirectory + "\\Teachers\\" + bunifuDataGridView1.Rows[i].Cells[0].Value + ".ini");
                file.Write("name", bunifuDataGridView1.Rows[i].Cells[1].Value.ToString());
                file.Write("surname", bunifuDataGridView1.Rows[i].Cells[2].Value.ToString());
                file.Write("unvan", bunifuDataGridView1.Rows[i].Cells[3].Value.ToString());
                file.Write("gunler", bunifuDataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            */
        }

    }
}
