using AutoMapper;
using Data.DBModels;
using Data.DTO.Add;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Config
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            //CreateMap<BeerAdd, Beer>()
            //    .ForMember(dest => dest.BreweryId,
            //    opt => opt.MapFrom(src=> src.Alcohol))
            //    .ForMember(dest => dest.BeerTypeId)
            //    ;
        }
    }
}
