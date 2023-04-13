namespace PersonelUI
{
    partial class PersonelListForm
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
            this.gcpersonellist = new System.Windows.Forms.DataGridView();
            this.gcGorevList = new System.Windows.Forms.DataGridView();
            this.btnistencikart = new System.Windows.Forms.Button();
            this.calısanlabel = new System.Windows.Forms.Label();
            this.ayrılanlabel = new System.Windows.Forms.Label();
            this.lbactivelist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcpersonellist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGorevList)).BeginInit();
            this.SuspendLayout();
            // 
            // gcpersonellist
            // 
            this.gcpersonellist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcpersonellist.Location = new System.Drawing.Point(12, 122);
            this.gcpersonellist.Name = "gcpersonellist";
            this.gcpersonellist.RowHeadersWidth = 51;
            this.gcpersonellist.RowTemplate.Height = 29;
            this.gcpersonellist.Size = new System.Drawing.Size(757, 316);
            this.gcpersonellist.TabIndex = 0;
            this.gcpersonellist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gcpersonellist_CellContentClick);
            // 
            // gcGorevList
            // 
            this.gcGorevList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcGorevList.Location = new System.Drawing.Point(795, 122);
            this.gcGorevList.Name = "gcGorevList";
            this.gcGorevList.RowHeadersWidth = 51;
            this.gcGorevList.RowTemplate.Height = 29;
            this.gcGorevList.Size = new System.Drawing.Size(302, 316);
            this.gcGorevList.TabIndex = 1;
            // 
            // btnistencikart
            // 
            this.btnistencikart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnistencikart.BackColor = System.Drawing.Color.Red;
            this.btnistencikart.Location = new System.Drawing.Point(199, 476);
            this.btnistencikart.Name = "btnistencikart";
            this.btnistencikart.Size = new System.Drawing.Size(402, 43);
            this.btnistencikart.TabIndex = 2;
            this.btnistencikart.Text = "İşten Çıkart";
            this.btnistencikart.UseVisualStyleBackColor = false;
            this.btnistencikart.Click += new System.EventHandler(this.btnistencikart_Click);
            // 
            // calısanlabel
            // 
            this.calısanlabel.AutoSize = true;
            this.calısanlabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.calısanlabel.Location = new System.Drawing.Point(56, 20);
            this.calısanlabel.Name = "calısanlabel";
            this.calısanlabel.Size = new System.Drawing.Size(144, 45);
            this.calısanlabel.TabIndex = 3;
            this.calısanlabel.Text = "Çalışan:";
            this.calısanlabel.Click += new System.EventHandler(this.calısanlabel_Click);
            // 
            // ayrılanlabel
            // 
            this.ayrılanlabel.AutoSize = true;
            this.ayrılanlabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ayrılanlabel.Location = new System.Drawing.Point(443, 20);
            this.ayrılanlabel.Name = "ayrılanlabel";
            this.ayrılanlabel.Size = new System.Drawing.Size(192, 45);
            this.ayrılanlabel.TabIndex = 4;
            this.ayrılanlabel.Text = "İşten Çıkan";
            this.ayrılanlabel.Click += new System.EventHandler(this.ayrılanlabel_Click);
            // 
            // lbactivelist
            // 
            this.lbactivelist.AutoSize = true;
            this.lbactivelist.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbactivelist.Location = new System.Drawing.Point(56, 74);
            this.lbactivelist.Name = "lbactivelist";
            this.lbactivelist.Size = new System.Drawing.Size(144, 45);
            this.lbactivelist.TabIndex = 5;
            this.lbactivelist.Text = "Çalışan:";
            this.lbactivelist.Click += new System.EventHandler(this.lbactivelist_Click);
            // 
            // PersonelListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 544);
            this.Controls.Add(this.lbactivelist);
            this.Controls.Add(this.ayrılanlabel);
            this.Controls.Add(this.calısanlabel);
            this.Controls.Add(this.btnistencikart);
            this.Controls.Add(this.gcGorevList);
            this.Controls.Add(this.gcpersonellist);
            this.Name = "PersonelListForm";
            this.Text = "PersonelListele";
            this.Load += new System.EventHandler(this.PersonelListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcpersonellist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGorevList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gcpersonellist;
        private DataGridView gcGorevList;
        private Button btnistencikart;
        private Label calısanlabel;
        private Label ayrılanlabel;
        private Label lbactivelist;
    }
}