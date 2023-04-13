using Core.DataAccess;
using Entities_.Concrete;
using Entities_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPersonelDal : IEntityRepository<Personeller>
    {
        
      
        bool CheckTc(string Tc_Kimlik_No);
        List<PersonelDto> GetPersonelList();
    }
}
