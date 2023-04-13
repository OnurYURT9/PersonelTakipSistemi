namespace PersonelUI
{
    partial class PersonellerForm
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
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbirhtday = new System.Windows.Forms.DateTimePicker();
            this.textstartingdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxtc = new System.Windows.Forms.TextBox();
            this.textogrenim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxtel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textadres = new System.Windows.Forms.TextBox();
            this.btnpersonelekleme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textgorev = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(143, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(530, 27);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.Enter += new System.EventHandler(this.textName_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Soyadı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textLastname
            // 
            this.textLastname.Location = new System.Drawing.Point(143, 60);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(530, 27);
            this.textLastname.TabIndex = 2;
            this.textLastname.Enter += new System.EventHandler(this.textLastname_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Doğum Tarihi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "İşe Başlama Tarihi";
            // 
            // textbirhtday
            // 
            this.textbirhtday.Location = new System.Drawing.Point(143, 160);
            this.textbirhtday.Name = "textbirhtday";
            this.textbirhtday.Size = new System.Drawing.Size(530, 27);
            this.textbirhtday.TabIndex = 12;
            // 
            // textstartingdate
            // 
            this.textstartingdate.Location = new System.Drawing.Point(143, 226);
            this.textstartingdate.Name = "textstartingdate";
            this.textstartingdate.Size = new System.Drawing.Size(530, 27);
            this.textstartingdate.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-5, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "ÖğrenimDurumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tc Kimlik Numarası";
            // 
            // textboxtc
            // 
            this.textboxtc.Location = new System.Drawing.Point(143, 93);
            this.textboxtc.MaxLength = 11;
            this.textboxtc.Name = "textboxtc";
            this.textboxtc.Size = new System.Drawing.Size(530, 27);
            this.textboxtc.TabIndex = 17;
            // 
            // textogrenim
            // 
            this.textogrenim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textogrenim.FormattingEnabled = true;
            this.textogrenim.Location = new System.Drawing.Point(143, 335);
            this.textogrenim.Name = "textogrenim";
            this.textogrenim.Size = new System.Drawing.Size(530, 28);
            this.textogrenim.TabIndex = 19;
            this.textogrenim.SelectedIndexChanged += new System.EventHandler(this.textogrenim_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Telefon Numarası";
            // 
            // textBoxtel
            // 
            this.textBoxtel.Location = new System.Drawing.Point(143, 126);
            this.textBoxtel.MaxLength = 10;
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.Size = new System.Drawing.Size(530, 27);
            this.textBoxtel.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Adres:";
            // 
            // textadres
            // 
            this.textadres.Location = new System.Drawing.Point(143, 193);
            this.textadres.MaxLength = 11;
            this.textadres.Multiline = true;
            this.textadres.Name = "textadres";
            this.textadres.Size = new System.Drawing.Size(530, 27);
            this.textadres.TabIndex = 24;
            // 
            // btnpersonelekleme
            // 
            this.btnpersonelekleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnpersonelekleme.Location = new System.Drawing.Point(143, 384);
            this.btnpersonelekleme.Name = "btnpersonelekleme";
            this.btnpersonelekleme.Size = new System.Drawing.Size(530, 42);
            this.btnpersonelekleme.TabIndex = 25;
            this.btnpersonelekleme.Text = "Personel Ekle";
            this.btnpersonelekleme.UseVisualStyleBackColor = false;
            this.btnpersonelekleme.Click += new System.EventHandler(this.btnpersonelekleme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Görevi:";
            // 
            // textgorev
            // 
            this.textgorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textgorev.FormattingEnabled = true;
            this.textgorev.Location = new System.Drawing.Point(138, 272);
            this.textgorev.Name = "textgorev";
            this.textgorev.Size = new System.Drawing.Size(535, 28);
            this.textgorev.TabIndex = 27;
            this.textgorev.SelectedIndexChanged += new System.EventHandler(this.textgorev_SelectedIndexChanged);
            // 
            // PersonellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textgorev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnpersonelekleme);
            this.Controls.Add(this.textadres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxtel);
            this.Controls.Add(this.textogrenim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textboxtc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textstartingdate);
            this.Controls.Add(this.textbirhtday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Name = "PersonellerForm";
            this.Text = "PersonellerForm";
            this.Load += new System.EventHandler(this.PersonellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textName;
        private Label label1;
        private Label label2;
        private TextBox textLastname;
        private Label label4;
        private Label label5;
        private DateTimePicker textbirhtday;
        private DateTimePicker textstartingdate;
        private Label label3;
        private Label label7;
        private TextBox textboxtc;
        private ComboBox textogrenim;
        private Label label8;
        private TextBox textBoxtel;
        private Label label9;
        private TextBox textadres;
        private Button btnpersonelekleme;
        private Label label6;
        private ComboBox textgorev;
    }
}