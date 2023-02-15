using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dersProgrami
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void Btnogretmenler_Click(object sender, EventArgs e)
        {
            new Ogretmenler().Show();
            this.Dispose();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();

        }

        private void Btndersler_Click(object sender, EventArgs e)
        {
            new Dersler().Show();
            this.Dispose();
        }
        private void Btnderslikler_Click(object sender, EventArgs e)
        {
            new Derslikler().Show();
            this.Dispose();
        }

        private void BtnDersProg_Click(object sender, EventArgs e)
        {
            new SubeBilgiler().Show();
            this.Dispose();
        }

        

        

        private void AnaMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.Btnderslikler = new Guna.UI2.WinForms.Guna2Button();
            this.btnGirisler = new Guna.UI2.WinForms.Guna2Button();
            this.Btndersler = new Guna.UI2.WinForms.Guna2Button();
            this.Btnogretmenler = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDersProg = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Btnderslikler
            // 
            this.Btnderslikler.CustomizableEdges = customizableEdges1;
            this.Btnderslikler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btnderslikler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btnderslikler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btnderslikler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btnderslikler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnderslikler.ForeColor = System.Drawing.Color.White;
            this.Btnderslikler.Location = new System.Drawing.Point(62, 60);
            this.Btnderslikler.Name = "Btnderslikler";
            this.Btnderslikler.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.Btnderslikler.Size = new System.Drawing.Size(225, 56);
            this.Btnderslikler.TabIndex = 0;
            this.Btnderslikler.Text = "DERSLİKLER";
            // 
            // btnGirisler
            // 
            this.btnGirisler.CustomizableEdges = customizableEdges3;
            this.btnGirisler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGirisler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGirisler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGirisler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGirisler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGirisler.ForeColor = System.Drawing.Color.White;
            this.btnGirisler.Location = new System.Drawing.Point(219, 158);
            this.btnGirisler.Name = "btnGirisler";
            this.btnGirisler.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btnGirisler.Size = new System.Drawing.Size(225, 56);
            this.btnGirisler.TabIndex = 1;
            this.btnGirisler.Text = "GİRİŞLER";
            // 
            // Btndersler
            // 
            this.Btndersler.CustomizableEdges = customizableEdges5;
            this.Btndersler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btndersler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btndersler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btndersler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btndersler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btndersler.ForeColor = System.Drawing.Color.White;
            this.Btndersler.Location = new System.Drawing.Point(414, 252);
            this.Btndersler.Name = "Btndersler";
            this.Btndersler.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.Btndersler.Size = new System.Drawing.Size(225, 56);
            this.Btndersler.TabIndex = 2;
            this.Btndersler.Text = "DERSLER";
            // 
            // Btnogretmenler
            // 
            this.Btnogretmenler.CustomizableEdges = customizableEdges7;
            this.Btnogretmenler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btnogretmenler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btnogretmenler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btnogretmenler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btnogretmenler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnogretmenler.ForeColor = System.Drawing.Color.White;
            this.Btnogretmenler.Location = new System.Drawing.Point(62, 252);
            this.Btnogretmenler.Name = "Btnogretmenler";
            this.Btnogretmenler.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.Btnogretmenler.Size = new System.Drawing.Size(225, 56);
            this.Btnogretmenler.TabIndex = 3;
            this.Btnogretmenler.Text = "ÖĞRETMENLER";
            // 
            // BtnDersProg
            // 
            this.BtnDersProg.CustomizableEdges = customizableEdges9;
            this.BtnDersProg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDersProg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDersProg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDersProg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDersProg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDersProg.ForeColor = System.Drawing.Color.White;
            this.BtnDersProg.Location = new System.Drawing.Point(414, 60);
            this.BtnDersProg.Name = "BtnDersProg";
            this.BtnDersProg.ShadowDecoration.CustomizableEdges = customizableEdges10;
            this.BtnDersProg.Size = new System.Drawing.Size(225, 56);
            this.BtnDersProg.TabIndex = 4;
            this.BtnDersProg.Text = "Program Oluşturucu";
            this.BtnDersProg.Click += new System.EventHandler(this.BtnDersProg_Click_1);
            // 
            // AnaMenu
            // 
            this.ClientSize = new System.Drawing.Size(789, 423);
            this.Controls.Add(this.BtnDersProg);
            this.Controls.Add(this.Btnogretmenler);
            this.Controls.Add(this.Btndersler);
            this.Controls.Add(this.btnGirisler);
            this.Controls.Add(this.Btnderslikler);
            this.Name = "AnaMenu";
            this.ResumeLayout(false);

        }

        private void BtnDersProg_Click_1(object sender, EventArgs e)
        {

        }
    }
}

