using Business.Abstract;
using Entities_.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelUI
{
    public partial class PersonellerForm : Form
    {
       
       
        private readonly IGorevService _gorevService;
        private readonly IOgrenimDurumService _ogrenimDurumService;
        private readonly IPersonelService _personelService;
        public PersonelListForm personellist;
        public PersonellerForm(IGorevService gorevService, IPersonelService personelService,IOgrenimDurumService ogrenimDurumService)
        {
            InitializeComponent();
            _gorevService= gorevService;   
            
            _ogrenimDurumService = ogrenimDurumService;
            _personelService = personelService;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=PersonelTakipSistemi;Integrated Security=true");
        int gorevId = 0;
        int ogrenimdurumId = 0;
        private void PersonellerForm_Load(object sender, EventArgs e)
        {
           var ogrenimdurumlars = _ogrenimDurumService.GetList();
            foreach(var ogrenimdurumlar in ogrenimdurumlars)
            {
                textogrenim.Items.Add(ogrenimdurumlar.OgrenimDurumu);
            }



            var gorevlers = _gorevService.GetList();  
            foreach (var gorevler in gorevlers)
            {
                textgorev.Items.Add(gorevler.Ad);
               
            }
           
            baglanti.Close();
            textbirhtday.Text = DateTime.Now.ToString("dd.MM.yyyy");
            textstartingdate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

      private void textbolum_SelectedIndexChanged(object sender, EventArgs e)
        {
           // bolumId = _bolumservice.GetBolumId(textbolum.Text);
           
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            ogrenimdurumId = _ogrenimDurumService.GetOgrenimDurumId(textogrenim.Text);
        }

        private void textName_Enter(object sender, EventArgs e)
        {
            textName.Focus();
            textName.SelectAll();
        }

        private void textLastname_Enter(object sender, EventArgs e)
        {
            textLastname.Focus();
            textLastname.SelectAll();
        }

        private void textogrenim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnpersonelekleme_Click(object sender, EventArgs e)
        {
           
            
            Personeller personeller = new Personeller
            {
                Dogum_Tarihi = Convert.ToDateTime(textbirhtday.Text),
                //      BolumId= bolumId,
                GorevId = gorevId,
                OgrenimDurumId = ogrenimdurumId,
                Ad = textName.Text,
                Soyad = textLastname.Text,
                Tc_Kimlik_No= textboxtc.Text,
                Telefon_Numarası = textBoxtel.Text,
                Adres = textadres.Text,
                
                Ise_Giris_Tarihi = Convert.ToDateTime(textstartingdate.Text),
                Durum = "Çalışıyor"
            };
            var result = _personelService.Add(personeller);
            if (result)
            {
                
                Clear();
            }
            
        }
        void Clear()
        {
            textName.Text = "";
            textLastname.Text = "";
            textbirhtday.Text = DateTime.Now.ToString("dd.MM.yyyy");
            textstartingdate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            textboxtc.Text = "";
            textgorev.Text = "";
            textogrenim.Text = "";
            textName.Focus();
        }
        private void textbolum_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textgorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            gorevId = _gorevService.GetGorevId(textgorev.Text);
        }
    }
}
