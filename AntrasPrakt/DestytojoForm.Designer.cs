
namespace AntrasPrakt
{
    partial class DestytojoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.įvestiPažymįToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pakeistiPažymįToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atsijungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.įvestiPažymįToolStripMenuItem,
            this.pakeistiPažymįToolStripMenuItem,
            this.atsijungtiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // įvestiPažymįToolStripMenuItem
            // 
            this.įvestiPažymįToolStripMenuItem.Name = "įvestiPažymįToolStripMenuItem";
            this.įvestiPažymįToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.įvestiPažymįToolStripMenuItem.Text = "Įvesti pažymį";
            this.įvestiPažymįToolStripMenuItem.Click += new System.EventHandler(this.įvestiPažymįToolStripMenuItem_Click);
            // 
            // pakeistiPažymįToolStripMenuItem
            // 
            this.pakeistiPažymįToolStripMenuItem.Name = "pakeistiPažymįToolStripMenuItem";
            this.pakeistiPažymįToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.pakeistiPažymįToolStripMenuItem.Text = "Pakeisti pažymį";
            this.pakeistiPažymįToolStripMenuItem.Click += new System.EventHandler(this.pakeistiPažymįToolStripMenuItem_Click);
            // 
            // atsijungtiToolStripMenuItem
            // 
            this.atsijungtiToolStripMenuItem.Name = "atsijungtiToolStripMenuItem";
            this.atsijungtiToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.atsijungtiToolStripMenuItem.Text = "Išeiti";
            this.atsijungtiToolStripMenuItem.Click += new System.EventHandler(this.atsijungtiToolStripMenuItem_Click);
            // 
            // DestytojoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DestytojoForm";
            this.Text = "DestytojoForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem įvestiPažymįToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atsijungtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pakeistiPažymįToolStripMenuItem;
    }
}