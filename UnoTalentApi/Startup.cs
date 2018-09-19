using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using UnoTalent.Data;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Service.Services;
using UnoTalent.Service.Mappers;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalentApi
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

            services.AddScoped<IMapper<User, UserVm>, UserMapper>();
            services.AddScoped<IMapper<Application, ApplicationVm>, ApplicationMapper>();
            services.AddScoped<IMapper<Question, QuestionVm>, QuestionMapper>();
            services.AddScoped<IMapper<Category, CategoryVm>, CategoryMapper>();
            services.AddScoped<IMapper<Candidate, CandidateVm>, CandidateMapper>();

            services.AddScoped<IApiService<UserVm>, UserService>();
            services.AddScoped<IApiService<ApplicationVm>, ApplicationService>();
            services.AddScoped<IApiService<QuestionVm>, QuestionService>();
            services.AddScoped<IApiService<CategoryVm>, CategoryService>();
            services.AddScoped<IApiService<CandidateVm>, CandidateService>();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=UnoTalent.Db;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<UnoTalentDbContext>
                (options => options.UseSqlServer(connection, b => b.MigrationsAssembly("UnoTalentApi")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
