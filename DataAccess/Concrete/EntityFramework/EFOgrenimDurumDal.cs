using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFOgrenimDurumDal : EFEntityRepositoryBase<Ogrenim_Durumlar, PersonelDbContext>, IOgrenimDurumDal
    {
     

        public List<Ogrenim_Durumlar> GetList()
        {
            using (var context = new PersonelDbContext())
            {
                var result = context.Ogrenim_Durumlars.ToList();
                return result;
            }
        }
    }
}
