using AutoMapper;
using Data.DTO.FormList;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BeerTypeService : IBeerTypeService {
        private readonly IBeerTypeRepository _beerTypeRepository;
        private readonly IMapper _mapper;

        public BeerTypeService(IBeerTypeRepository beerTypeRepository, IMapper mapper) {
            this._beerTypeRepository = beerTypeRepository;
            this._mapper = mapper;
        }

        public List<BeerTypeFormList> GetAllBeerTypeFormList() {
            var resultDb = _beerTypeRepository.GetAll();
            var result = new List<BeerTypeFormList>();
            if(resultDb != null) {
                foreach (var obj in resultDb)
                    result.Add(_mapper.Map<BeerTypeFormList>(obj));
                return result;
            }
            return null;
        }
    }
}
