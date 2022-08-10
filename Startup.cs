using Microsoft.EntityFrameworkCore;

using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using prueba.Models;

namespace prueba
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }
        
        
        
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(opciones =>{}).AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));

            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddAutoMapper(typeof(Startup).Assembly);
        }



 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILogger<Startup> logger)//
        {
           if (env.IsDevelopment())
            {
                // app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
    
}