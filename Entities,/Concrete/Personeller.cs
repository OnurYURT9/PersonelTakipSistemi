using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_.Concrete
{
    public class Personeller
    {
        public int Id { get; set; }
        public int GorevId { get; set; }
        public int OgrenimDurumId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc_Kimlik_No { get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public string Adres { get; set; }
        public string Telefon_Numarası { get; set; }
        public DateTime Ise_Giris_Tarihi { get; set; }
        public DateTime? Isten_Cikis_Tarihi { get; set; }
        public string Durum { get; set; }
    }
}
