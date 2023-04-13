using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelUI
{
    public partial class BolumlerForm : Form
    {
        private readonly IBolumService _bolumService;
        
        public BolumlerForm(IBolumService bolumService)
        {
            InitializeComponent();
            _bolumService = bolumService;
        }

      

        private void Bolumler_Load(object sender, EventArgs e)
        {
            GetList();
        }
        void Clear()
        {
            txtbolum.Text = "";
        }
        void GetList()
        {
            var result = _bolumService.GetList();
            var bindingList = new BindingList<Bolumler>(result);
            dataGridView.DataSource = bindingList;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Bolumler bolumler = new Bolumler
            {
                Isim = txtbolum.Text,
                Durum = true
            };
            var result = _bolumService.Add(bolumler);
            if (result)
            {
                MessageBox.Show("Bölüm başarıyla eklendi","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetList();
                Clear();
            }
            else
            {
                MessageBox.Show("Bir hatayla karşılaştık","Hata:",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {
                Bolumler temp = new Bolumler();
                temp.Id = (int)item.Cells["Id"].Value;
                _bolumService.Delete(temp);

                dataGridView.Rows.RemoveAt(item.Index);
            }


            /*int selectedIndex = dataGridView.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                var data = (List<Bolumler>)dataGridView.DataSource;
                data.RemoveAt(selectedIndex);

                dataGridView.DataSource = data;
                dataGridView.Refresh();


                //dataGridView.Rows.RemoveAt(selectedIndex);
                //dataGridView.Refresh();
            }*/
        }
    }
}
