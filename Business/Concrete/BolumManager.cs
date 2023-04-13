using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConserns.Validation;
using DataAccess.Abstract;
using Entities_.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BolumManager : IBolumService
    {
        private readonly IBolumDal _bolumdal;

        public BolumManager(IBolumDal bolumdal)
        {
            _bolumdal = bolumdal;
        }

        public bool Add(Bolumler bolumler)
        {
            bool validation = ValidationTool.Validate(new BolumValidator(),bolumler);
            if (validation)
            {
                _bolumdal.Add(bolumler);
                MessageBox.Show("Bölüm başarıyla kaydedilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
           return false;
        }

        public int GetBolumId(string bolumName)
        {
            return _bolumdal.GetList().Where(d => d.Isim == bolumName).Select(x => x.Id).FirstOrDefault();
        }

        public void Delete(Bolumler bolumler)
        {
            _bolumdal.Delete(bolumler);
        }

        public Bolumler Get(int id)
        {
            return _bolumdal.Get(b=>b.Id == id);
        }

        public List<Bolumler> GetList()
        {
            return _bolumdal.GetList();
        }

     
    }
}
