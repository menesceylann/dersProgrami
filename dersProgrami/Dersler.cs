using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using dersProgrami.Base_Class;
using dersProgrami.Managers;

namespace dersProgrami
{
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }

        private void Dersler_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            setupCheckedList();
            setupDataGrid();
        }

        LinkedList<Base_Class.Teacher> cList = new LinkedList<Base_Class.Teacher>();

        void setupCheckedList()
        {
            foreach (Base_Class.Teacher t in Managers.OgretmenManager.GetAll())
            {
                cList.AddLast(t);
                teacherList.Items.Add(t.name);
            }
        }

        void addListe(string dersName, string dersKod, string[] tId, string saat)
        {
            dataList.Rows.Add();
            try
            {
                dataList.Rows[dataList.Rows.Count - 1].Cells[0].Value = int.Parse(dataList.Rows[dataList.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
            }
            catch (Exception)
            {
                dataList.Rows[dataList.Rows.Count - 1].Cells[0].Value = 0;
            }
            dataList.Rows[dataList.Rows.Count - 1].Cells[1].Value = dersName;
            dataList.Rows[dataList.Rows.Count - 1].Cells[2].Value = dersKod;
            dataList.Rows[dataList.Rows.Count - 1].Cells[4].Value = saat;

            string rawData = "";
            for (int i = 0; i < tId.Length; i++)
            {
                rawData += tId[i].ToString() + ",";
                //foreach(FileInfo f in new DirectoryInfo(Environment.CurrentDirectory + "\\Teachers").GetFiles())
                //{
                //    IniFile fi = new IniFile(Environment.CurrentDirectory + "\\Teachers" + f.Name);
                //    if (tId[i].Equals(f.Name.Substring(0, f.Name.Length - 4)))
                //    {
                //        rawData += fi.Read("name") + ",";
                //        break;
                //    }
                //}
            }
            rawData = rawData.Substring(0, rawData.Length - 1);
            dataList.Rows[dataList.Rows.Count - 1].Cells[3].Value = rawData;
        }

        void setupDataGrid()
        {

            foreach (Base_Class.Class s in Managers.ClassManager.GetAll())
            {
                addListe(s.name, s.dersKod, Managers.OgretmenManager.GetTeacherNameWithId(s.teachers), s.saat.ToString());
            }

        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string data = "";
            string rawData = "";

            for (int i = 0; i < teacherList.CheckedItems.Count; i++)
            {
                //data += teacherList.CheckedItems[0];
                data += cList.ToArray()[teacherList.Items.IndexOf(teacherList.CheckedItems[0])].id.ToString() + ",";
                rawData += teacherList.CheckedItems[i].ToString() + ",";
            }
            data = data.Substring(0, data.Length - 1);
            rawData = rawData.Substring(0, rawData.Length - 1);



            addListe(txtName.Text, txtKod.Text, rawData.Split(','), txtSaat.Text);
            Managers.ClassManager.AddClass(new Base_Class.Class(int.Parse(dataList.Rows[dataList.Rows.Count - 1].Cells[0].Value.ToString()), txtName.Text, txtKod.Text, Managers.OgretmenManager.initializeOgretmen(data.Split(',')), int.Parse(txtSaat.Text)));
        }

        private void Dersler_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AnaMenu().Show();
            Managers.ClassManager.Save();
        }

        private void teacherList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
