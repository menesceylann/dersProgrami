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
using dersProgrami.Managers;
using dersProgrami.Base_Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace dersProgrami
{
    public partial class Derslikler : Form
    {
        public Derslikler()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (bunifuTextBox1.Text.Equals(String.Empty) || bunifuTextBox2.Text.Equals(string.Empty) || comboBox1.Text.Equals(string.Empty))
                return;
            if (duzenle)
            {

                DerslikManager.SetDerslik(did, new Derslik(did, bunifuTextBox2.Text, (comboBox1.Text.Equals("Derslik")) ? Derslik.DerslikTipi.Derslik : Derslik.DerslikTipi.Laboratuvar, int.Parse(bunifuTextBox1.Text)));
            }
            else
            {

                addListe(bunifuTextBox2.Text, comboBox1.Text, bunifuTextBox1.Text);
                DerslikManager.addDerslik(new Derslik(int.Parse(bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value.ToString()),
                bunifuTextBox2.Text,
                    ((comboBox1.Text.Equals("Derslik")) ? Derslik.DerslikTipi.Derslik : Derslik.DerslikTipi.Laboratuvar),
                    int.Parse(bunifuTextBox1.Text)));
            }
            bunifuTextBox1.Text = String.Empty;
            bunifuTextBox2.Text = String.Empty;
            comboBox1.Text = "Derslik";
        }

        void addListe(string name, string type, string kapasite)
        {
            bunifuDataGridView1.Rows.Add();
            try
            {
                bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value = int.Parse(bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
            }
            catch (Exception)
            {
                bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value = 0;
            }
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[1].Value = name;
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[2].Value = type;
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[3].Value = kapasite;
        }

        void listele()
        {
            bunifuDataGridView1.Rows.Clear();
            foreach (Derslik s in DerslikManager.GetAllClass())
            {
                addListe(s.name, s.dersTip.ToString(), s.kapasite.ToString());
            }
            GC.Collect();
        }


        private void Derslikler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Derslikler_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AnaMenu().Show();
        }

        bool duzenle = false;
        int did;

        private void bunifuDataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            duzenle = true;
            did = int.Parse(bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            bunifuTextBox2.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bunifuTextBox1.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}

