using dersProgrami.Base_Class;
using dersProgrami.Managers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace dersProgrami
{
    public partial class Ogretmenler : Form
    {
        public Ogretmenler()
        {
            InitializeComponent();
        }

        private void Ogretmenler_Load(object sender, EventArgs e)
        {
            listele();
        }
        void addListe(string name, string surname, string unvan, string[] gunler)
        {
            bunifuDataGridView1.Rows.Add();
            try
            {
                if (bunifuDataGridView1.Rows.Count <= 1)
                    bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value = 0;
                else
                    bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value = (bunifuDataGridView1.Rows.Count <= 1) ? 0 : int.Parse(bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
            }
            catch (NullReferenceException)
            {
                bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value = 0;
            }
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[1].Value = name;
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[2].Value = surname;
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[3].Value = unvan;
            string rawText = "";
            foreach (string s in gunler)
            {
                rawText += s + ",";
            }
            rawText = rawText.Substring(0, rawText.Length - 1);

            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[4].Value = rawText;
        }

        void listele()
        {
            foreach (Teacher t in OgretmenManager.GetAll())
            {
                addListe(t.name, t.surname, t.unvan, GunManager.GetGuns(t.musaitGunler));
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            LinkedList<string> str = new LinkedList<string>();
            if (checkBox1.Checked)
                str.AddLast("Pazartesi");
            if (checkBox2.Checked)
                str.AddLast("Salı");
            if (checkBox3.Checked)
                str.AddLast("Çarşamba");
            if (checkBox4.Checked)
                str.AddLast("Perşembe");
            if (checkBox5.Checked)
                str.AddLast("Cuma");
            if (checkBox6.Checked)
                str.AddLast("Cumartesi");
            if (checkBox7.Checked)
                str.AddLast("Pazar");
            addListe(bunifuTextBox1.Text, bunifuTextBox2.Text, txtOgretmenAdi.Text, str.ToArray());
            OgretmenManager.addOgretmen(new Teacher(int.Parse(bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value.ToString()), bunifuTextBox1.Text, bunifuTextBox2.Text, txtOgretmenAdi.Text, GunManager.initializeGun(str.ToArray())));

        }


        private void Ogretmenler_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AnaMenu().Show();

        }
        private void btnSil_Click(object sender, EventArgs e)
        {

        }

    }
}
