using Business.Abstract;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelUI
{
    public partial class GorevlerForm : Form
    {
        private readonly IBolumService _bolumService;
        private readonly IGorevService _gorevService;
        private List<Bolumler> _bolumler;

        public GorevlerForm(IBolumService bolumService, IGorevService gorevService)
        {
            InitializeComponent();
            _bolumService= bolumService;
            _gorevService= gorevService;
        }
      
        private void Gorevler_Load(object sender, EventArgs e)
        {
          
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
        }
       
      

        private void btnkaydet_Click_1(object sender, EventArgs e)
        {
            var bolum = _bolumler.Where(x => x.Isim == textbolum.Text).First();

            Gorevler gorevler = new Gorevler
            {
                Ad = textgorev.Text,
                BolumId = bolum.Id,
                
            };
            var result = _gorevService.Add(gorevler);
            fillList();
        }
        
        private void GorevlerForm_Load(object sender, EventArgs e)
        {
            _bolumler = _bolumService.GetList();
            foreach (var bolumler in _bolumler)
            {
                textbolum.Items.Add(bolumler.Isim);
            }

            fillList();
        }

        void fillList()
        {
            var result = _gorevService.GetList();
            var bindingList = new BindingList<Gorevler>(result);
            dataGridView1.DataSource = bindingList;
        }
    }
}
