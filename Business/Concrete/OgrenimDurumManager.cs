using Business.Abstract;
using DataAccess.Abstract;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OgrenimDurumManager : IOgrenimDurumService
    {
        private readonly IOgrenimDurumDal _ogrenimDurumDal;
        public OgrenimDurumManager(IOgrenimDurumDal ogrenimDurumDal)
        {
            _ogrenimDurumDal=ogrenimDurumDal;
        }
        public Ogrenim_Durumlar Get(int id)
        {
            return _ogrenimDurumDal.Get(o=>o.Id==id);
        }

        public List<Ogrenim_Durumlar> GetList()
        {
            return _ogrenimDurumDal.GetList();
        }

        public int GetOgrenimDurumId(string ogrenimdurumu)
        {
            return _ogrenimDurumDal.GetList().Where(d => d.OgrenimDurumu == ogrenimdurumu).Select(x => x.Id).FirstOrDefault();
        }
    }
}
