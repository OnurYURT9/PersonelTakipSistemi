namespace PersonelUI
{
    partial class AnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnpersonel = new System.Windows.Forms.Button();
            this.btnbolum = new System.Windows.Forms.Button();
            this.btnperekleme = new System.Windows.Forms.Button();
            this.btnGorevler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpersonel
            // 
            this.btnpersonel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnpersonel.Location = new System.Drawing.Point(61, 66);
            this.btnpersonel.Name = "btnpersonel";
            this.btnpersonel.Size = new System.Drawing.Size(104, 119);
            this.btnpersonel.TabIndex = 0;
            this.btnpersonel.Text = "Personel Listesi";
            this.btnpersonel.UseVisualStyleBackColor = false;
            this.btnpersonel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbolum
            // 
            this.btnbolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnbolum.Location = new System.Drawing.Point(610, 66);
            this.btnbolum.Name = "btnbolum";
            this.btnbolum.Size = new System.Drawing.Size(114, 119);
            this.btnbolum.TabIndex = 1;
            this.btnbolum.Text = "Bölümler";
            this.btnbolum.UseVisualStyleBackColor = false;
            this.btnbolum.Click += new System.EventHandler(this.btnbolum_Click);
            // 
            // btnperekleme
            // 
            this.btnperekleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnperekleme.Location = new System.Drawing.Point(337, 66);
            this.btnperekleme.Name = "btnperekleme";
            this.btnperekleme.Size = new System.Drawing.Size(104, 119);
            this.btnperekleme.TabIndex = 2;
            this.btnperekleme.Text = "Personel Ekle";
            this.btnperekleme.UseVisualStyleBackColor = false;
            this.btnperekleme.Click += new System.EventHandler(this.btnperekleme_Click);
            // 
            // btnGorevler
            // 
            this.btnGorevler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGorevler.Location = new System.Drawing.Point(61, 217);
            this.btnGorevler.Name = "btnGorevler";
            this.btnGorevler.Size = new System.Drawing.Size(104, 113);
            this.btnGorevler.TabIndex = 3;
            this.btnGorevler.Text = "Görevler";
            this.btnGorevler.UseVisualStyleBackColor = false;
            this.btnGorevler.Click += new System.EventHandler(this.btnGorevler_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGorevler);
            this.Controls.Add(this.btnperekleme);
            this.Controls.Add(this.btnbolum);
            this.Controls.Add(this.btnpersonel);
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnpersonel;
        private Button btnbolum;
        private Button btnperekleme;
        private Button btnGorevler;
    }
}