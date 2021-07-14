using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KeepAPet.Core.Common;
using KeepAPet.Infra.Common;
using KeepAPet.Infra.Repository;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using KeepAPets.Infra.Repository;
using KeepAPets.Infra.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;

namespace KeepAPet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IDBContext, DBContext>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IClinicRepository, ClinicRepository>();
            services.AddScoped<IPetRepository, PetRepository>();
            services.AddScoped<ISalesRepository, SaleRepository>();
            services.AddScoped<IDoctorsRepository, DoctorsRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IOfferRepository, OfferRepository>();
            services.AddScoped<IPetForSaleRepository, PetForSaleRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IJobTitleRepository, JobTitleRepository>();
            services.AddScoped<IRateRepository, RateRepository>();
            services.AddScoped<IDiseasesRepository, DiseasesRepository>();
            //services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<IExtraRepository, ExtraRepository>();
          //  services.AddScoped<IJwtAuthRepository, JwtAuthRepository>();
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<ICustomerServices, CustomerServices>();
            services.AddScoped<ILocationServices, LocationServices>();
            services.AddScoped<IReviewServices, ReviewServices>();
            services.AddScoped<IReservationServices, ReservationServices>();
            services.AddScoped<IClinicServices, ClinicServices>();
            services.AddScoped<IPetServices, PetServices>();
            services.AddScoped<ISalesServices, SaleServices>();
            services.AddScoped<IDoctorsServices, DoctorsServices>();
            services.AddScoped<IPaymentServices, PaymentServices>();
            services.AddScoped<IOfferServices, OfferServices>();
            services.AddScoped<IPetForSaleServices, PetForSaleServices>();
            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddScoped<IJobTitleServices, JobTitleServices>();
            services.AddScoped<IDiseasesServices, DiseasesServices>();
            //services.AddScoped<IBillServices, BillServices>();
            services.AddScoped<IFoodServices, FoodServices>();
            services.AddScoped<IExtraServices, ExtraServices>();
            services.AddScoped<IRateServices, RateServices>();
           // services.AddScoped<IJwtAuthServices, JwtAuthServices>();
            services.AddCors();
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
                 .AllowAnyHeader());
            }); 
           


            services.AddControllersWithViews()
               .AddNewtonsoftJson(options =>
               options.SerializerSettings.ReferenceLoopHandling = Newtonsoft
               .Json.ReferenceLoopHandling.Ignore)
               .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
               = new DefaultContractResolver());



            //services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddControllers().AddNewtonsoftJson();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "KeepAPet", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "KeepAPet v1"));
            }

            app.UseRouting();
            app.UseCors(m => m.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "Photos")),
                RequestPath = "/Photos"
            });
        }
    }
}
