using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Week8Project.Core.Dtos;
using Week8Project.Core.Entities;

namespace Week8Project.Core.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductDto>();

            //CreateMap<User, UserForListDTO>()
            //    .ForMember(dest => dest.PhotoUrl, opt =>
            //        opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
            //    .ForMember(dest => dest.Age, opt =>
            //        opt.MapFrom(src => src.Birthday.CalculateAge()));
            //CreateMap<Photo, PhotoInfoDTO>();
        }
    }
}
