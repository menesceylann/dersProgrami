using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using dersProgrami.Base_Class;
using dersProgrami.Managers;

namespace dersProgrami
{
    public partial class SubeBilgiler : Form
    {
        public SubeBilgiler()
        {
            InitializeComponent();
        }

        LinkedList<Base_Class.Class> classes = new LinkedList<Base_Class.Class>();


        private void SubeBilgiler_Load(object sender, EventArgs e)
        {
            foreach (Base_Class.Class c in Managers.ClassManager.GetAll())
            {
                classes.AddLast(c);
                checkedListBox1.Items.Add(c.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dersBaslangic = comboBox1.Text + "-" + comboBox2.Text;
            string oglenArasiBaslangic = comboBox4.Text + "-" + comboBox3.Text;
            string oglenArasiSaat = comboBox6.Text + "-" + comboBox5.Text;
            string kacSaatDers = comboBox7.Text;
            string tenefusSuresi = comboBox8.Text;
            string dersSaati = comboBox9.Text;
            LinkedList<Base_Class.Class> c = new LinkedList<Base_Class.Class>();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                c.AddLast(classes.ToArray()[checkedListBox1.Items.IndexOf(checkedListBox1.CheckedItems[i])]);
            }

            new ProgramOlusturucu(c.ToArray(), dersBaslangic, oglenArasiBaslangic, oglenArasiSaat, kacSaatDers, tenefusSuresi, dersSaati).Show();
            this.Dispose();

        }

        private void SubeBilgiler_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            new AnaMenu().Show();
        }


    }
}