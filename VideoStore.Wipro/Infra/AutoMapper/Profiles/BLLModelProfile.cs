using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoStore.Wipro.BLL.Infra.Model;

namespace VideoStore.Wipro.Infra.AutoMapper.Profiles
{
    public class BLLModelProfile : Profile
    {       
        public BLLModelProfile()
        {
            CreateMap<ClientInputModel, ClientModel>();
            CreateMap<MovieInputModel, MovieModel>();
            CreateMap<RentMovieInputModel, RentMovieModel>()
                .ForMember(x=> x.ReturnDate, map => map.MapFrom(src => src.StartRent.AddDays(src.DaysRent)));
             
        }
    }
}
