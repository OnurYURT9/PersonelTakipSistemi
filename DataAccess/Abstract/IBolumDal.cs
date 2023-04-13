using Core.DataAccess;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBolumDal : IEntityRepository<Bolumler>
    {
        
        List<Bolumler> GetList();

    }
}
