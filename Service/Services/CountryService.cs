using AutoMapper;
using Data.DTO.FormList;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CountryService : ICountryService {
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository, IMapper mapper) {
            this._countryRepository = countryRepository;
            _mapper = mapper;
        }

        public List<CountryFormList> GetAllFormList() {
            var resultDb = _countryRepository.GetAll();
            List<CountryFormList> result = new List<CountryFormList>();
            if (resultDb != null) {
                foreach (var obj in resultDb)
                    result.Add(_mapper.Map<CountryFormList>(obj));
                return result;
            }
            return null;
        }
    }
}
