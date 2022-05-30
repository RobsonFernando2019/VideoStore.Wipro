using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoStore.Wipro.BLL;
using VideoStore.Wipro.BLL.Infra;

namespace VideoStore.Wipro.Infra
{
    public static class ServiceExtension
    {
        public static void AddWebAPIServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region BLL
            services.AddScoped<IVideoStoreBLL, VideoStoreBLL>();
            #endregion
        }
    }
}
