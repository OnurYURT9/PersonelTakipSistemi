using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConserns.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities_.Concrete;
using Entities_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public bool Add(Personeller personeller)
        {
            bool validation = ValidationTool.Validate(new PersonelValidator(), personeller);
            if (validation)
            {
                var result = _personelDal.CheckTc(personeller.Tc_Kimlik_No);
                if (!result)
                {
                    MessageBox.Show("Bu tc daha önce kullanılmış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _personelDal.Add(personeller);
                MessageBox.Show("Personel başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public void Delete(Personeller personeller)
        {
            _personelDal.Delete(personeller);
        }

        public Personeller Get(int id)
        {
            return _personelDal.Get(e => e.Id == id);
        }

        public List<Personeller> GetAll()
        {
            return _personelDal.GetList();
        }

        public List<PersonelDto> GetPersonelList()
        {
            return _personelDal.GetPersonelList();
        }

        public void QuitJob(Personeller personeller)
        {
            _personelDal.Update(personeller);
            MessageBox.Show("Personel çıkış yaptı","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Update(Personeller personeller)
        {
            bool validation = ValidationTool.Validate(new PersonelValidator(), personeller);
            if (validation)
            {
                var findPersonel = _personelDal.Get(i => i.Id == personeller.Id);
                var result = true;
                if (findPersonel.Tc_Kimlik_No != personeller.Tc_Kimlik_No)
                {
                    result = _personelDal.CheckTc(personeller.Tc_Kimlik_No);
                    if (!result)
                    {
                        MessageBox.Show("Bu tc daha önce kullanılmış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                _personelDal.Update(personeller);
                MessageBox.Show("Personel başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
