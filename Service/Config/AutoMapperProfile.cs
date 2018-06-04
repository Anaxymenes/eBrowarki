using AutoMapper;
using Data.DBModels;
using Data.DTO;
using Data.DTO.Add;
using Data.DTO.Edit;
using Service.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Config
{
    public class AutoMapperProfile: Profile
    {
        private readonly IMapper _mapper;

        public AutoMapperProfile(IMapper mapper)
        {
            _mapper = mapper;
        }

        public AutoMapperProfile() {

            CreateMap<BeerAdd, Beer>()
                .ForMember(dest => dest.BreweryId,
                opt => opt.MapFrom(src => src.ProducerId))
                .ForMember(dest => dest.Alcohol,
                opt => opt.MapFrom(src => src.Alcohol))
                ;

            CreateMap<BeerAdd, Product>()
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description,
                opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Picture,
                opt => opt.MapFrom(src => src.Picture))
                .ForMember(dest => dest.CountryId,
                opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.Date,
                opt => opt.UseValue(DateTime.Now))
                ;

            CreateMap<BreweryAdd, Brewery>()
                .ForMember(dest => dest.Place,
                opt => opt.MapFrom(src => src.Place))
                .ForMember(dest => dest.PostalCode,
                opt => opt.MapFrom(src => src.PostalCode))
                ;

            CreateMap<BreweryAdd, Product>()
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description,
                opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Picture,
                opt => opt.MapFrom(src => src.Picture))
                .ForMember(dest => dest.CountryId,
                opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.Date,
                opt => opt.UseValue(DateTime.Now))
                ;

            CreateMap<BeerTypeBeerDTO, BeerTypeBeer>()
                .ForMember(dest => dest.BeerTypeId,
                opt => opt.MapFrom(src => src.BeerTypeId))
                ;

            CreateMap<ProductAdd, Product>()
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description,
                opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Picture,
                opt => opt.MapFrom(src => src.Picture))
                .ForMember(dest => dest.CountryId,
                opt => opt.MapFrom(src => src.CountryId))
                ;
            
            CreateMap<Account, AccountDTO>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Username,
                opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Email,
                opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Avatar,
                opt => opt.MapFrom(src => src.Avatar))
                .ForMember(dest => dest.Role,
                opt => opt.MapFrom(src => src.Role.Name))
                ;

            CreateMap<Account, AccountLoginVerificationDTO > ()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Username,
                opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Email,
                opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Avatar,
                opt => opt.MapFrom(src => src.Avatar))
                .ForMember(dest => dest.Role,
                opt => opt.MapFrom(src => src.Role.Name))
                .ForMember(dest => dest.Active,
                opt => opt.MapFrom(src => src.Active))
                .ForMember(dest => dest.Password,
                opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PasswordSalt,
                opt => opt.MapFrom(src => src.PasswordSalt))
                ;


            byte[] salt = null;
            CreateMap<RegisterAccountDTO, Account>()
                .BeforeMap((src, dest) => salt = AuthMethods.GetSalt())
                .ForMember(dest => dest.Email,
                opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Username,
                opt => opt.MapFrom(src => src.Email.Substring(0, src.Email.IndexOf('@'))))
                .ForMember(dest => dest.Active,
                opt => opt.UseValue(false))
                .ForMember(dest => dest.RoleId,
                opt => opt.UseValue(3))
                .ForMember(dest => dest.Password,
                opt => opt.MapFrom(src => AuthMethods.GetHashedPassword(src.Password, salt)))
                .ForMember(dest => dest.PasswordSalt,
                opt => opt.MapFrom(src => AuthMethods.EncodeByteToString(salt)))
                .ForMember(dest => dest.Blocked,
                opt => opt.UseValue(false))
                .ForMember(dest => dest.Avatar,
                opt => opt.UseValue("nonProfile.png"))
                ;

            CreateMap<Beer, BeerDTO>()
                .ForMember(dest => dest.Alcohol,
                opt => opt.MapFrom(src => src.Alcohol))
                .ForMember(dest => dest.ProducerId,
                opt => opt.MapFrom(src => src.Brewery.Id))
                .ForMember(dest => dest.Producer,
                opt => opt.MapFrom(src => src.Brewery.Product.Name))
                ;

            CreateMap<BeerDTO, Beer>()
                .ForMember(dest => dest.Alcohol,
                opt => opt.MapFrom(src => src.Alcohol))
                .ForMember(dest => dest.BreweryId,
                opt => opt.MapFrom(src => src.ProducerId))
                ;

            CreateMap<Brewery, BreweryDTO>()
                .ForMember(dest => dest.Place,
                opt => opt.MapFrom(src => src.Place))
                .ForMember(dest => dest.PostalCode,
                opt => opt.MapFrom(src => src.PostalCode))
                .ForMember(dest => dest.PostOffice,
                opt => opt.MapFrom(src => src.PostOffice))
                .ForMember(dest => dest.Street,
                opt => opt.MapFrom(src => src.Street))
                .ForMember(dest => dest.NumberOfBuilding,
                opt => opt.MapFrom(src => src.NumberOfBuilding))
                ;

            CreateMap<Comment, CommentDTO>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Date,
                opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.Content,
                opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.Author,
                opt => opt.MapFrom(src => src.Account.Username))
                .ForMember(dest => dest.AccountId,
                opt => opt.MapFrom(src => src.AccountId))
                ;

            CreateMap<CommentAdd, Comment>()
                .ForMember(dest => dest.ProductId,
                opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Content,
                opt => opt.MapFrom(src => src.Content))
                ;

            CreateMap<CommentEdit, Comment>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Date,
                opt => opt.UseValue(DateTime.Now))
                .ForMember(dest => dest.AccountId,
                opt => opt.MapFrom(src => src.AccountId))
                .ForMember(dest => dest.ProductId,
                opt => opt.MapFrom(src => src.ProductId))
                ;

            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description,
                opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Date,
                opt => opt.MapFrom(src => src.Date))

                .ForMember(dest => dest.Vote,
                opt => opt.Ignore())
                .AfterMap((src, dest) => {
                    if (src.Votes != null && src.Votes.Count > 0) {
                        double voteResult = 0;
                        foreach (var obj in src.Votes)
                            voteResult += obj.VoteValue;
                        dest.Vote = voteResult / src.Votes.Count;
                    }
                })
                .ForMember(dest => dest.Picture,
                opt => opt.MapFrom(src => src.Picture))
                .ForMember(dest => dest.CountryId,
                opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.Country,
                opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.Comments,
                opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    if(src.Comments != null && src.Comments.Count > 0)
                    {
                        List<CommentDTO> result = new List<CommentDTO>();
                        foreach (var obj in src.Comments) {
                            CommentDTO com = new CommentDTO() {
                                Id = obj.Id,
                                AccountId = obj.AccountId,
                                Author = obj.Account.Username,
                                Content = obj.Content,
                                Date = obj.Date
                            };
                            result.Add(com);
                        }
                        dest.Comments = result;
                    }
                })
                ;
        }
    }
}
