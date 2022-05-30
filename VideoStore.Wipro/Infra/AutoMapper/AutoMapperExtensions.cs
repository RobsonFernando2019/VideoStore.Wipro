using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using VideoStore.Wipro.Infra.AutoMapper.Profiles;

namespace VideoStore.Wipro.Infra.AutoMapper
{
    public static class AutoMapperExtensions
    {
        public static void AddMapperProfiles (this IServiceCollection services)
        {
            services.AddAutoMapper(typeof (BLLModelProfile));            
        }
    }
}
