using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dersProgrami.Base_Class;

namespace dersProgrami.Managers
{
    public class LoginManager
    {

        protected static LinkedList<User> list = new LinkedList<User>();

        public LoginManager()
        {
            LoadFile();
        }

        public static User GetUser(int id )
        {
            foreach(User s in list)
            {
                if (s.id == id)
                    return s;
            }
            return null;
        }

        public static void AddUser(User s)
        {
            list.AddLast(s);
        }

        public static void SetUser(int id, User user)
        {
            foreach (User s in list)
            {
                if (s.id == id)
                {
                    list.Remove(s);
                    break;
                }
            }
            AddUser(user);
        }

        public static bool RemoveUser(int id)
        {
            foreach( User s in list)
            {
                if(s.id == id)
                {
                    list.Remove(s);
                    File.Delete(Environment.CurrentDirectory + "\\Users\\" + s.id.ToString() + ".ini");
                    return true;
                }    
            }
            return false;
        }

        public static User[] GetAll()
        {
            return list.ToArray();
        }

        void LoadFile()
        {
            foreach(FileInfo f in new DirectoryInfo(Environment.CurrentDirectory + "\\Users").GetFiles())
            {
                IniFile file = new IniFile(f.FullName);
                User s = new User();
                s.id = int.Parse(f.Name.Substring(0, f.Name.Length - 4));
                s.username = file.Read("username");
                s.password = file.Read("password");
                s.yetki = file.Read("yetki");
                list.AddLast(s);
            }
        }

        public static void Save()
        {
            foreach(User s in list)
            {
                IniFile file = new IniFile(Environment.CurrentDirectory + "\\Users\\" + s.id.ToString() + ".ini");
                file.Write("username", s.username);
                file.Write("password", s.password);
                file.Write("yetki", s.yetki);
            }
        }

    }
}
