using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dersProgrami.Managers;
using dersProgrami.Base_Class;

namespace dersProgrami
{
    public partial class ProgramOlusturucu : Form
    {

        Base_Class.Class[] dersler;
        string dersBaslangic;
        string oglenArasiBaslangic;
        string oglenArasiSaat;
        string kacSaatDers;
        string tenefusSuresi;
        int dersSaati;

        public ProgramOlusturucu(Base_Class.Class[] dersler, string dersBaslangic, string oglenArasiBaslangic, string oglenArasiSaat, string kacSaatDers, string tenefusSuresi, string dersSaati)
        {
            InitializeComponent();
            this.dersler = dersler;
            this.dersBaslangic = dersBaslangic;
            this.oglenArasiBaslangic = oglenArasiBaslangic;
            this.oglenArasiSaat = oglenArasiSaat;
            this.kacSaatDers = kacSaatDers;
            this.tenefusSuresi = tenefusSuresi;
            this.dersSaati = int.Parse(dersSaati);
        }

        LinkedList<ProgramPanel> panel = new LinkedList<ProgramPanel>();

        private void ProgramOlusturucu_Load(object sender, EventArgs e)
        {
            olustur();
            drawProgram();
        }

        string[] Pazartesi;
        string[] Salı;
        string[] Çarşamba;
        string[] Perşembe;
        string[] Cuma;

        void drawProgram()
        {
            int saat = int.Parse(dersBaslangic.Split('-')[0]);
            int dakika = int.Parse(dersBaslangic.Split('-')[1]);
            foreach (string s in Pazartesi)
            {
                int yenidakika = dakika + dersSaati;
                int yenisaat = saat;
                if (yenidakika >= 60)
                {
                    yenidakika -= 60;
                    yenisaat += 1;
                }
                if (s == null || s.Equals(null) || s.Equals(""))
                    continue;
                if (!s.Contains('-'))
                    continue;
                Base_Class.Class c = Managers.ClassManager.getClass(int.Parse(s.Split('-')[1]));
                string ogretmenler = "";
                for (int i = 0; i < c.teachers.Length; i++)
                {
                    ogretmenler += c.teachers[i].name + ",";
                }
                ogretmenler = ogretmenler.Substring(0, ogretmenler.Length - 1);
                ProgramPanel p = new ProgramPanel(c.name, ogretmenler, saat + " " + dakika + "-" + yenisaat + " " + yenidakika);
                yenidakika += int.Parse(tenefusSuresi);
                if (yenidakika >= 60)
                {
                    yenisaat++;
                    yenidakika -= 60;
                }
                saat = yenisaat;
                dakika = yenidakika;
                if (dakika * saat >= int.Parse(oglenArasiBaslangic.Split('-')[1]) + (int.Parse(oglenArasiBaslangic.Split('-')[0]) * 60) && int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]) >= saat * dakika)
                {

                    dakika += int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]);
                    while (true)
                    {
                        if (dakika >= 60)
                        {
                            saat += 1;
                            dakika -= 60;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                panel.AddLast(p);
                p.Visible = true;
                listPazartesi.Controls.Add(p);

            }
            saat = int.Parse(dersBaslangic.Split('-')[0]);
            dakika = int.Parse(dersBaslangic.Split('-')[1]);
            foreach (string s in Salı)
            {
                int yenidakika = dakika + dersSaati;
                int yenisaat = saat;
                if (yenidakika >= 60)
                {
                    yenidakika -= 60;
                    yenisaat += 1;
                }
                if (s == null || s.Equals(null) || s.Equals(""))
                    continue;
                if (!s.Contains('-'))
                    continue;
                Base_Class.Class c = Managers.ClassManager.getClass(int.Parse(s.Split('-')[1]));
                string ogretmenler = "";
                for (int i = 0; i < c.teachers.Length; i++)
                {
                    ogretmenler += c.teachers[i].name + ",";
                }
                ogretmenler = ogretmenler.Substring(0, ogretmenler.Length - 1);
                ProgramPanel p = new ProgramPanel(c.name, ogretmenler, saat + " " + dakika + "-" + yenisaat + " " + yenidakika);
                yenidakika += int.Parse(tenefusSuresi);
                if (yenidakika >= 60)
                {
                    yenisaat++;
                    yenidakika -= 60;
                }
                saat = yenisaat;
                dakika = yenidakika;
                if (dakika * saat >= int.Parse(oglenArasiBaslangic.Split('-')[1]) + (int.Parse(oglenArasiBaslangic.Split('-')[0]) * 60) && int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]) >= saat * dakika)
                {

                    dakika += int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]);
                    while (true)
                    {
                        if (dakika >= 60)
                        {
                            saat += 1;
                            dakika -= 60;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                panel.AddLast(p);
                p.Visible = true;
                listSalı.Controls.Add(p);
            }
            saat = int.Parse(dersBaslangic.Split('-')[0]);
            dakika = int.Parse(dersBaslangic.Split('-')[1]);
            foreach (string s in Çarşamba)
            {
                int yenidakika = dakika + dersSaati;
                int yenisaat = saat;
                if (yenidakika >= 60)
                {
                    yenidakika -= 60;
                    yenisaat += 1;
                }
                if (s == null || s.Equals(null) || s.Equals(""))
                    continue;
                if (!s.Contains('-'))
                    continue;
                Base_Class.Class c = Managers.ClassManager.getClass(int.Parse(s.Split('-')[1]));
                string ogretmenler = "";
                for (int i = 0; i < c.teachers.Length; i++)
                {
                    ogretmenler += c.teachers[i].name + ",";
                }
                ogretmenler = ogretmenler.Substring(0, ogretmenler.Length - 1);
                ProgramPanel p = new ProgramPanel(c.name, ogretmenler, saat + " " + dakika + "-" + yenisaat + " " + yenidakika);
                yenidakika += int.Parse(tenefusSuresi);
                if (yenidakika >= 60)
                {
                    yenisaat++;
                    yenidakika -= 60;
                }
                saat = yenisaat;
                dakika = yenidakika;
                if (dakika * saat >= int.Parse(oglenArasiBaslangic.Split('-')[1]) + (int.Parse(oglenArasiBaslangic.Split('-')[0]) * 60) && int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]) >= saat * dakika)
                {

                    dakika += int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]);
                    while (true)
                    {
                        if (dakika >= 60)
                        {
                            saat += 1;
                            dakika -= 60;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                panel.AddLast(p);
                p.Visible = true;
                listÇarşamba.Controls.Add(p);
            }
            saat = int.Parse(dersBaslangic.Split('-')[0]);
            dakika = int.Parse(dersBaslangic.Split('-')[1]);
            foreach (string s in Perşembe)
            {
                int yenidakika = dakika + dersSaati;
                int yenisaat = saat;
                if (yenidakika >= 60)
                {
                    yenidakika -= 60;
                    yenisaat += 1;
                }
                if (s == null || s.Equals(null) || s.Equals(""))
                    continue;
                if (!s.Contains('-'))
                    continue;
                Base_Class.Class c = Managers.ClassManager.getClass(int.Parse(s.Split('-')[1]));
                string ogretmenler = "";
                for (int i = 0; i < c.teachers.Length; i++)
                {
                    ogretmenler += c.teachers[i].name + ",";
                }
                ogretmenler = ogretmenler.Substring(0, ogretmenler.Length - 1);
                saat = yenisaat;
                dakika = yenidakika;
                if (dakika * saat >= int.Parse(oglenArasiBaslangic.Split('-')[1]) + (int.Parse(oglenArasiBaslangic.Split('-')[0]) * 60) && int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]) >= saat * dakika)
                {

                    dakika += int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]);
                    while (true)
                    {
                        if (dakika >= 60)
                        {
                            saat += 1;
                            dakika -= 60;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                ProgramPanel p = new ProgramPanel(c.name, ogretmenler, saat + " " + dakika + "-" + yenisaat + " " + yenidakika);
                yenidakika += int.Parse(tenefusSuresi);
                if (yenidakika >= 60)
                {
                    yenisaat++;
                    yenidakika -= 60;
                }
                panel.AddLast(p);
                p.Visible = true;
                listPerşembe.Controls.Add(p);
            }
            saat = int.Parse(dersBaslangic.Split('-')[0]);
            dakika = int.Parse(dersBaslangic.Split('-')[1]);
            foreach (string s in Cuma)
            {
                int yenidakika = dakika + dersSaati;
                int yenisaat = saat;
                if (yenidakika >= 60)
                {
                    yenidakika -= 60;
                    yenisaat += 1;
                }
                if (s == null || s.Equals(null) || s.Equals(""))
                    continue;
                if (!s.Contains('-'))
                    continue;
                Base_Class.Class c = Managers.ClassManager.getClass(int.Parse(s.Split('-')[1]));
                string ogretmenler = "";
                for (int i = 0; i < c.teachers.Length; i++)
                {
                    ogretmenler += c.teachers[i].name + ",";
                }
                ogretmenler = ogretmenler.Substring(0, ogretmenler.Length - 1);
                ProgramPanel p = new ProgramPanel(c.name, ogretmenler, saat + " " + dakika + "-" + yenisaat + " " + yenidakika);
                yenidakika += int.Parse(tenefusSuresi);
                if (yenidakika >= 60)
                {
                    yenisaat++;
                    yenidakika -= 60;
                }
                saat = yenisaat;
                dakika = yenidakika;
                if (dakika * saat >= int.Parse(oglenArasiBaslangic.Split('-')[1]) + (int.Parse(oglenArasiBaslangic.Split('-')[0]) * 60) && int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]) >= saat * dakika)
                {

                    dakika += int.Parse(oglenArasiSaat.Split('-')[0]) * int.Parse(oglenArasiSaat.Split('-')[1]);
                    while (true)
                    {
                        if (dakika >= 60)
                        {
                            saat += 1;
                            dakika -= 60;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                panel.AddLast(p);
                p.Visible = true;
                listCuma.Controls.Add(p);
            }
        }

        void olustur()
        {
            int gunluksaat = int.Parse(kacSaatDers);
            LinkedList<string> dizi = new LinkedList<string>();
            foreach (string s in diziOlustur())
            {
                foreach (string a in s.Split(','))
                    dizi.AddLast(a);
            }

            Random rand = new Random();

            string[] Pazartesi = new string[gunluksaat];
            string[] Salı = new string[gunluksaat];
            string[] Çarşamba = new string[gunluksaat];
            string[] Perşembe = new string[gunluksaat];
            string[] Cuma = new string[gunluksaat];
            for (int a = 0; a < 5; a++)
            {
                if (dizi.Count <= 0)
                    break;
                for (int i = 0; i < gunluksaat; i++)
                {
                    if (dizi.Count <= 0)
                        break;
                    int rsayi = rand.Next(dizi.Count);
                    switch (a)
                    {
                        case 0:
                            Pazartesi[i] = dizi.ToArray()[rsayi];
                            break;
                        case 1:
                            Salı[i] = dizi.ToArray()[rsayi];
                            break;
                        case 2:
                            Çarşamba[i] = dizi.ToArray()[rsayi];
                            break;
                        case 3:
                            Perşembe[i] = dizi.ToArray()[rsayi];
                            break;
                        case 4:
                            Cuma[i] = dizi.ToArray()[rsayi];
                            break;
                    }
                    dizi.Remove(dizi.ToArray()[rsayi]);

                }
            }

            this.Pazartesi = Pazartesi;
            this.Salı = Salı;
            this.Çarşamba = Çarşamba;
            this.Perşembe = Perşembe;
            this.Cuma = Cuma;
        }

        string[] diziOlustur()
        {

            string rawData = "";
            int sayi = 0;
            foreach (Base_Class.Class c in dersler)
            {
                for (int i = 0; i < c.saat; i++)
                {
                    rawData += i + "-" + c.id + ",";
                }
                rawData = rawData.Substring(0, rawData.Length - 1);
                rawData += "|";
            }
            rawData = rawData.Substring(0, rawData.Length - 1);

            return rawData.Split('|');

        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
        }


        private void ProgramOlusturucu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            new AnaMenu().Show();
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Panel grd = panels;
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void listPazartesi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
