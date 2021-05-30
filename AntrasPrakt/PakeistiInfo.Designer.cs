
namespace AntrasPrakt
{
    partial class PakeistiInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Irašykite studento ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dabartinė grupė:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perkelti į grupę:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pakeisti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "PI20",
            "KS20",
            "IS20",
            "PS20"});
            this.comboBoxFrom.Location = new System.Drawing.Point(213, 119);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 4;
            this.comboBoxFrom.Text = "--";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "PI21",
            "KS21",
            "IS21",
            "PS21"});
            this.comboBoxTo.Location = new System.Drawing.Point(213, 196);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTo.TabIndex = 5;
            this.comboBoxTo.Text = "--";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(213, 49);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 20);
            this.textBoxID.TabIndex = 6;
            // 
            // PakeistiInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 323);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PakeistiInfo";
            this.Text = "PakeistiInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.TextBox textBoxID;
    }
}