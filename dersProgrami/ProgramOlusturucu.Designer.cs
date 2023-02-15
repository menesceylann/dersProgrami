namespace dersProgrami
{
    partial class ProgramOlusturucu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.yazdir = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panels = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.listPazartesi = new System.Windows.Forms.FlowLayoutPanel();
            this.listSalı = new System.Windows.Forms.FlowLayoutPanel();
            this.listÇarşamba = new System.Windows.Forms.FlowLayoutPanel();
            this.listPerşembe = new System.Windows.Forms.FlowLayoutPanel();
            this.listCuma = new System.Windows.Forms.FlowLayoutPanel();
            this.panels.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yazdir
            // 
            this.yazdir.CustomizableEdges = customizableEdges1;
            this.yazdir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.yazdir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.yazdir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.yazdir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.yazdir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yazdir.ForeColor = System.Drawing.Color.White;
            this.yazdir.Location = new System.Drawing.Point(862, 704);
            this.yazdir.Name = "yazdir";
            this.yazdir.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.yazdir.Size = new System.Drawing.Size(121, 23);
            this.yazdir.TabIndex = 0;
            this.yazdir.Text = "Yazdır";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAZARTESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SALI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÇARŞAMBA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "PERŞEMBE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(839, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "CUMA";
            // 
            // panels
            // 
            this.panels.Controls.Add(this.panel2);
            this.panels.CustomizableEdges = customizableEdges3;
            this.panels.Location = new System.Drawing.Point(2, 3);
            this.panels.Name = "panels";
            this.panels.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.panels.Size = new System.Drawing.Size(980, 36);
            this.panels.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 804);
            this.panel2.TabIndex = 8;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.listCuma);
            this.guna2GradientPanel1.Controls.Add(this.listPerşembe);
            this.guna2GradientPanel1.Controls.Add(this.listÇarşamba);
            this.guna2GradientPanel1.Controls.Add(this.listSalı);
            this.guna2GradientPanel1.Controls.Add(this.listPazartesi);
            this.guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 38);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(980, 660);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // listPazartesi
            // 
            this.listPazartesi.Location = new System.Drawing.Point(0, 1);
            this.listPazartesi.Name = "listPazartesi";
            this.listPazartesi.Size = new System.Drawing.Size(176, 656);
            this.listPazartesi.TabIndex = 0;
            // 
            // listSalı
            // 
            this.listSalı.Location = new System.Drawing.Point(182, 4);
            this.listSalı.Name = "listSalı";
            this.listSalı.Size = new System.Drawing.Size(188, 656);
            this.listSalı.TabIndex = 1;
            // 
            // listÇarşamba
            // 
            this.listÇarşamba.Location = new System.Drawing.Point(376, 4);
            this.listÇarşamba.Name = "listÇarşamba";
            this.listÇarşamba.Size = new System.Drawing.Size(209, 656);
            this.listÇarşamba.TabIndex = 1;
            // 
            // listPerşembe
            // 
            this.listPerşembe.Location = new System.Drawing.Point(591, 4);
            this.listPerşembe.Name = "listPerşembe";
            this.listPerşembe.Size = new System.Drawing.Size(193, 656);
            this.listPerşembe.TabIndex = 1;
            // 
            // listCuma
            // 
            this.listCuma.Location = new System.Drawing.Point(790, 4);
            this.listCuma.Name = "listCuma";
            this.listCuma.Size = new System.Drawing.Size(187, 656);
            this.listCuma.TabIndex = 1;
            // 
            // ProgramOlusturucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 739);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panels);
            this.Controls.Add(this.yazdir);
            this.Name = "ProgramOlusturucu";
            this.Text = "ProgramOlusturucu";
            this.Load += new System.EventHandler(this.ProgramOlusturucu_Load);
            this.panels.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button yazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2GradientPanel panels;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Panel panel2;
        private FlowLayoutPanel listCuma;
        private FlowLayoutPanel listPerşembe;
        private FlowLayoutPanel listÇarşamba;
        private FlowLayoutPanel listSalı;
        private FlowLayoutPanel listPazartesi;
    }
}