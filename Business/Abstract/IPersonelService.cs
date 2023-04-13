using Entities_.Concrete;
using Entities_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        bool Add(Personeller personeller);
        bool Update(Personeller personeller);
        void QuitJob(Personeller personeller);
        void Delete(Personeller personeller);
        List<Personeller> GetAll();
        Personeller Get(int id);
        List<PersonelDto> GetPersonelList();
    }
}
