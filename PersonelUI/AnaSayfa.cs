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
    public partial class AnaSayfa : Form
    {
        private readonly IBolumService _bolumService;
        private readonly IPersonelService _personelService;
        private readonly IGorevService _gorevservice;
        private readonly IOgrenimDurumService _ogrenimdurumservice;
        public PersonelListForm personelListForm;
        public AnaSayfa(IBolumService bolumService, IPersonelService personelService,IGorevService gorevService,IOgrenimDurumService ogrenimDurumService)
        {
            InitializeComponent();
            _bolumService = bolumService;
            _personelService= personelService;
            _gorevservice = gorevService;
            _ogrenimdurumservice = ogrenimDurumService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            personelListForm = new PersonelListForm(_personelService,_gorevservice);
            personelListForm.Show();
        }

        private void btnbolum_Click(object sender, EventArgs e)
        {
            BolumlerForm bolumler;
            bolumler = new BolumlerForm(_bolumService);
            bolumler.Show();
        }
      
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
           
        }
      
        private void btnperekleme_Click(object sender, EventArgs e)
        {
            PersonellerForm personeller;
            personeller = new PersonellerForm(_gorevservice,_personelService,_ogrenimdurumservice );
            personeller.personellist = personelListForm;
            personeller.Show();
        }

        private void btnGorevler_Click(object sender, EventArgs e)
        {
            GorevlerForm gorevler;
            gorevler = new GorevlerForm(_bolumService,_gorevservice);
            gorevler.Show();
        }

        
    }
}
