using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekakoskatl.Web.App_Start
{
    public class StartUpConfig
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<EkakoskatlWebEntity>(options => options.UseSqlServer(Configuration.GetConnectionString("EkakoskatlWebEntity")));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IGenderServices, GenderServices>();
            services.AddTransient<IVideoGenderServices, VideoGenderServices>();
            services.AddTransient<IVideoServices, VideoServices>();
        }
    }
}