using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities_.Concrete;
using Entities_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFPersonelDal : EFEntityRepositoryBase<Personeller, PersonelDbContext>, IPersonelDal
    {
      

        public bool CheckTc(string Tc_Kimlik_No)
        {
            using (var context = new PersonelDbContext())
            {
                var result = context.Personellers.Where(e => e.Tc_Kimlik_No == Tc_Kimlik_No);
                return (result.Count()>0  ? false:true);
            }
        }

        public List<PersonelDto> GetPersonelList()
        {
            using (var context = new PersonelDbContext())
            {
                var result = from personeller in context.Personellers
                             join gorevler in context.Gorevlers on
                             personeller.GorevId equals gorevler.Id
                             select new PersonelDto
                             {
                                 Id = personeller.Id,
                                 GorevId = gorevler.Id,
                                 OgrenimDurumId = personeller.OgrenimDurumId,
                                 Dogum_Tarihi = personeller.Dogum_Tarihi,
                                 Adres = personeller.Adres,
                                 Ad = personeller.Ad,
                                 Soyad = personeller.Soyad,
                                 Durum = personeller.Durum,
                                 Ise_Giris_Tarihi = personeller.Ise_Giris_Tarihi,
                                 GorevAd = gorevler.Ad,
                                 Tc_Kimlik_No = personeller.Tc_Kimlik_No,
                                 Telefon_Numarası = personeller.Telefon_Numarası,
                             };
                return result.ToList();
            }
        }

        
    }
}
