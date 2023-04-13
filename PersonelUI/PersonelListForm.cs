using Business.Abstract;
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
    public partial class PersonelListForm : Form
    {
        private readonly IPersonelService _personelService;
        private readonly IGorevService _gorevService;
        public PersonelListForm(IPersonelService personelService,IGorevService gorevService)
        {
            InitializeComponent();
            _personelService = personelService;
            _gorevService = gorevService;
        }

        private void PersonelListForm_Load(object sender, EventArgs e)
        {
           GetList();
        }

        public void GetList()
        {
            var personellist = _personelService.GetPersonelList();
            gcpersonellist.DataSource = personellist.Where(e=>e.Durum == "Çalışıyor").ToList();

            var gorevList = _gorevService.GetListPersonelCount();
            gcGorevList.DataSource = gorevList;

            int personeller = personellist.Where(e => e.Durum == "Çalışıyor").Count();
            int dismiss = personellist.Where(e => e.Durum == "İşten Ayrıldı").Count() ;
            calısanlabel.Text = "Çalışan:" + personeller;
            ayrılanlabel.Text = "İşten Ayrılan:" + dismiss;

            lbactivelist.Text = "Çalışan Listesi";
        }
        void GetOffPersonelList()
        {
            var personelList = _personelService.GetPersonelList().Where(e => e.Durum == "İşten Ayrıldı").ToList();
            gcpersonellist.DataSource = personelList;
            lbactivelist.Text = "Ayrılanlar Listesi";
        }  
       
        private void gcpersonellist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnistencikart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in gcpersonellist.SelectedRows)
            {
                Personeller temp = new Personeller();
                temp.Id = (int)item.Cells["Id"].Value;
                _personelService.Delete(temp);

                gcpersonellist.Rows.RemoveAt(item.Index);
            }
        }

        private void ayrılanlabel_Click(object sender, EventArgs e)
        {
            GetOffPersonelList();
        }

        private void calısanlabel_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void lbactivelist_Click(object sender, EventArgs e)
        {

        }
    }
}
