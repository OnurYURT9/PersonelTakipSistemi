using Core.DataAccess;
using Entities_.Concrete;
using Entities_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGorevService
    {
        bool Add(Gorevler gorevler);

        void Delete(Gorevler gorevler);
        Gorevler Get(int id);
        int GetGorevId(string gorevName);
        List<Gorevler> GetList();
        List<GorevDto> GetListPersonelCount();
  
    }
}
