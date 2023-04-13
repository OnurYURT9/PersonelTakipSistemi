using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConserns.Validation;
using DataAccess.Abstract;
using Entities_.Concrete;
using Entities_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GorevManager : IGorevService
    {
        private readonly IGorevDal _gorevDal;

        public GorevManager(IGorevDal gorevDal)
        {
            _gorevDal= gorevDal;
        }
        public bool Add(Gorevler gorevler)
        {
            bool validation = ValidationTool.Validate(new GorevValidator(), gorevler);
            if (validation)
            {
                _gorevDal.Add(gorevler);
                MessageBox.Show("Görev başarıyla kaydedilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public void Delete(Gorevler gorevler)
        {
            _gorevDal.Delete(gorevler);
        }

        public Gorevler Get(int id)
        {
            return _gorevDal.Get(g=>g.Id==id);
        }

       

        public int GetGorevId(string gorevName)
        {
            return _gorevDal.GetList().Where(d => d.Ad == gorevName).Select(x => x.Id).FirstOrDefault();
        }

        public List<Gorevler> GetList()
        {
            return _gorevDal.GetList();
        }

        public List<GorevDto> GetListPersonelCount()
        {
            return _gorevDal.GetListPersonelCount();
        }
    }
}
