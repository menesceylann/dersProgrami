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

namespace dersProgrami
{
    public partial class ProgramPanel : UserControl
    {
        public ProgramPanel(string dersAdi, string ogretmenAdi, string Saat)
        {
            InitializeComponent();

            textBox1.Text = dersAdi;
            textBox2.Text = ogretmenAdi;
            textBox3.Text = Saat;
        }

        private void ProgramPanel_Load(object sender, EventArgs e)
        {
        }

        public string getDersAdi()
        {
            return textBox1.Text;
        }

        public string getOgretmenAdi()
        {
            return textBox2.Text;
        }

        public string getSaat()
        {
            return textBox3.Text;
        }
    }
}
