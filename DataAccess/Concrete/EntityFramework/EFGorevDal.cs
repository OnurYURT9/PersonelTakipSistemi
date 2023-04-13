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
    public class EFGorevDal : EFEntityRepositoryBase<Gorevler,PersonelDbContext>,IGorevDal
    {


        public List<Gorevler> GetList()
        {
            using (var context = new PersonelDbContext())
            {


                var result = from gorevler in context.Gorevlers
                             select new Gorevler
                             {
                                 Id = gorevler.Id,
                                 Ad = gorevler.Ad,
                                 BolumId = gorevler.BolumId,
                             };
                                 
                return result.ToList();
            }
        }

        public List<GorevDto> GetListPersonelCount()
        {
            using(var context = new PersonelDbContext())
            {
                var result = from gorevler in context.Gorevlers
                             select new GorevDto
                             {
                                 Id = gorevler.Id,
                                 Ad = gorevler.Ad,
                                 PersonelSayisi = context.Personellers.Where(p => p.GorevId == gorevler.Id && p.Durum != "Ayrıldı").Count()
                             };
                return result.ToList();
                
            }
        }
    }
}
