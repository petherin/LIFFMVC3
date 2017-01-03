using LIFF.Data.Infrastructure;
using LIFF.Data.Repositories;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Service
{
    public interface ICountryService
    {
        IEnumerable<Country> GetCountries();
        Country GetCountryByName(string countryName);
        Country GetCountry(int id);
        void CreateCountry(Country country);
        void SaveCountry();
    }

    public class CountryService : ICountryService
    {
        private readonly ICountryRepository countryRepository;
        private readonly IUnitOfWork unitOfWork;

        public CountryService(ICountryRepository countryRepository, IUnitOfWork unitOfWork)
        {
            this.countryRepository = countryRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ICountryService Members
        public void CreateCountry(Country country)
        {
            countryRepository.Add(country);
        }

        public IEnumerable<Country> GetCountries()
        {
            var countries = countryRepository.GetAll();
            return countries;
        }

        public Country GetCountry(int id)
        {
            var country = countryRepository.GetById(id);
            return country;
        }

        public Country GetCountryByName(string countryName)
        {
            var country = countryRepository.Get(c => c.Name == countryName);
            return country;
        }

        public void SaveCountry()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
