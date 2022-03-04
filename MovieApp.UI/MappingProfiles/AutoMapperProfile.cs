using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MovieApp.UI.Models;

namespace MovieApp.UI.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category,CategoryEntity>(); 
            CreateMap<CategoryEntity,Category>(); 
            CreateMap<Movie,MovieEntity>();
            CreateMap<MovieEntity,Movie>();
        }   
    }
}