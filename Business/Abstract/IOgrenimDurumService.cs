using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOgrenimDurumService
    {
        Ogrenim_Durumlar Get(int id);
        int GetOgrenimDurumId(string OgrenimDurumu);
        List<Ogrenim_Durumlar> GetList();
    }
}
