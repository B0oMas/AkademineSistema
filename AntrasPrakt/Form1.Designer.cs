namespace AntrasPrakt
{
    partial class Form1
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naujasNaudotojasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentoPaieškaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pakeistiGrupeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.destytojaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naujasDėstytojasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ieškotiDėstytojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasalintiStudentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pašalintiStudentąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pašalintiDėstytojąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atsijungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudentas = new System.Windows.Forms.Button();
            this.btnDestytojas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(342, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Prisijungti administratoriui";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prisijungimo vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Slaptazodis";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(156, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registracijaToolStripMenuItem,
            this.studentoToolStripMenuItem,
            this.destytojaiToolStripMenuItem,
            this.pasalintiStudentaToolStripMenuItem,
            this.atsijungtiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registracijaToolStripMenuItem
            // 
            this.registracijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naujasNaudotojasToolStripMenuItem});
            this.registracijaToolStripMenuItem.Name = "registracijaToolStripMenuItem";
            this.registracijaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.registracijaToolStripMenuItem.Text = "Registracija";
            // 
            // naujasNaudotojasToolStripMenuItem
            // 
            this.naujasNaudotojasToolStripMenuItem.Name = "naujasNaudotojasToolStripMenuItem";
            this.naujasNaudotojasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.naujasNaudotojasToolStripMenuItem.Text = "Naujas studentas";
            this.naujasNaudotojasToolStripMenuItem.Click += new System.EventHandler(this.naujasNaudotojasToolStripMenuItem_Click);
            // 
            // studentoToolStripMenuItem
            // 
            this.studentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentoPaieškaToolStripMenuItem,
            this.pakeistiGrupeToolStripMenuItem1});
            this.studentoToolStripMenuItem.Name = "studentoToolStripMenuItem";
            this.studentoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.studentoToolStripMenuItem.Text = "Studento info";
            // 
            // studentoPaieškaToolStripMenuItem
            // 
            this.studentoPaieškaToolStripMenuItem.Name = "studentoPaieškaToolStripMenuItem";
            this.studentoPaieškaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.studentoPaieškaToolStripMenuItem.Text = "Studento paieška";
            this.studentoPaieškaToolStripMenuItem.Click += new System.EventHandler(this.studentoPaieškaToolStripMenuItem_Click);
            // 
            // pakeistiGrupeToolStripMenuItem1
            // 
            this.pakeistiGrupeToolStripMenuItem1.Name = "pakeistiGrupeToolStripMenuItem1";
            this.pakeistiGrupeToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.pakeistiGrupeToolStripMenuItem1.Text = "Pakeisti grupe";
            this.pakeistiGrupeToolStripMenuItem1.Click += new System.EventHandler(this.pakeistiGrupeToolStripMenuItem1_Click);
            // 
            // destytojaiToolStripMenuItem
            // 
            this.destytojaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naujasDėstytojasToolStripMenuItem,
            this.ieškotiDėstytojoToolStripMenuItem});
            this.destytojaiToolStripMenuItem.Name = "destytojaiToolStripMenuItem";
            this.destytojaiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.destytojaiToolStripMenuItem.Text = "Dėstytojai";
            // 
            // naujasDėstytojasToolStripMenuItem
            // 
            this.naujasDėstytojasToolStripMenuItem.Name = "naujasDėstytojasToolStripMenuItem";
            this.naujasDėstytojasToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.naujasDėstytojasToolStripMenuItem.Text = "Naujas dėstytojas";
            this.naujasDėstytojasToolStripMenuItem.Click += new System.EventHandler(this.naujasDėstytojasToolStripMenuItem_Click);
            // 
            // ieškotiDėstytojoToolStripMenuItem
            // 
            this.ieškotiDėstytojoToolStripMenuItem.Name = "ieškotiDėstytojoToolStripMenuItem";
            this.ieškotiDėstytojoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ieškotiDėstytojoToolStripMenuItem.Text = "Ieškoti dėstytojo";
            this.ieškotiDėstytojoToolStripMenuItem.Click += new System.EventHandler(this.ieškotiDėstytojoToolStripMenuItem_Click);
            // 
            // pasalintiStudentaToolStripMenuItem
            // 
            this.pasalintiStudentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pašalintiStudentąToolStripMenuItem,
            this.pašalintiDėstytojąToolStripMenuItem});
            this.pasalintiStudentaToolStripMenuItem.Name = "pasalintiStudentaToolStripMenuItem";
            this.pasalintiStudentaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pasalintiStudentaToolStripMenuItem.Text = "Pašalinti";
            // 
            // pašalintiStudentąToolStripMenuItem
            // 
            this.pašalintiStudentąToolStripMenuItem.Name = "pašalintiStudentąToolStripMenuItem";
            this.pašalintiStudentąToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pašalintiStudentąToolStripMenuItem.Text = "Pašalinti studentą";
            this.pašalintiStudentąToolStripMenuItem.Click += new System.EventHandler(this.pašalintiStudentąToolStripMenuItem_Click);
            // 
            // pašalintiDėstytojąToolStripMenuItem
            // 
            this.pašalintiDėstytojąToolStripMenuItem.Name = "pašalintiDėstytojąToolStripMenuItem";
            this.pašalintiDėstytojąToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pašalintiDėstytojąToolStripMenuItem.Text = "Pašalinti dėstytoją";
            this.pašalintiDėstytojąToolStripMenuItem.Click += new System.EventHandler(this.pašalintiDėstytojąToolStripMenuItem_Click);
            // 
            // atsijungtiToolStripMenuItem
            // 
            this.atsijungtiToolStripMenuItem.Name = "atsijungtiToolStripMenuItem";
            this.atsijungtiToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.atsijungtiToolStripMenuItem.Text = "Išeiti";
            this.atsijungtiToolStripMenuItem.Click += new System.EventHandler(this.atsijungtiToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "PRISIJUNGIMAS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStudentas);
            this.panel1.Controls.Add(this.btnDestytojas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(344, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 258);
            this.panel1.TabIndex = 7;
            // 
            // btnStudentas
            // 
            this.btnStudentas.Location = new System.Drawing.Point(182, 186);
            this.btnStudentas.Name = "btnStudentas";
            this.btnStudentas.Size = new System.Drawing.Size(102, 50);
            this.btnStudentas.TabIndex = 8;
            this.btnStudentas.Text = "Prisijungti studentui";
            this.btnStudentas.UseVisualStyleBackColor = true;
            this.btnStudentas.Click += new System.EventHandler(this.btnStudentas_Click);
            // 
            // btnDestytojas
            // 
            this.btnDestytojas.Location = new System.Drawing.Point(38, 186);
            this.btnDestytojas.Name = "btnDestytojas";
            this.btnDestytojas.Size = new System.Drawing.Size(102, 50);
            this.btnDestytojas.TabIndex = 7;
            this.btnDestytojas.Text = "Prisijungti dėstytojui";
            this.btnDestytojas.UseVisualStyleBackColor = true;
            this.btnDestytojas.Click += new System.EventHandler(this.btnDestytojas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destytojaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasalintiStudentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atsijungtiToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem naujasNaudotojasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentoPaieškaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naujasDėstytojasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ieškotiDėstytojoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pašalintiStudentąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pašalintiDėstytojąToolStripMenuItem;
        private System.Windows.Forms.Button btnStudentas;
        private System.Windows.Forms.Button btnDestytojas;
        private System.Windows.Forms.ToolStripMenuItem pakeistiGrupeToolStripMenuItem1;
    }
}

