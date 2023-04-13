using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBolumService
    {
        bool Add(Bolumler bolumler);
       
        void Delete(Bolumler bolumler);
        Bolumler Get(int id);
        int GetBolumId (string bolumName);
        List<Bolumler> GetList();
    }
}
