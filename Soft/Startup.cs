using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Domain.Participant;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Infra;
using SportClub.Infra.Coach;
using SportClub.Infra.CoachOfTraining;
using SportClub.Infra.Participant;
using SportClub.Infra.ParticipantOfTraining;
using SportClub.Infra.Training;
using SportClub.Infra.TrainingType;
using SportClub.Soft.Data;

namespace SportClub.Soft
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<SportClubDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddScoped<ICoachesRepository, CoachesRepository>();
            services.AddScoped<ICoachOfTrainingsRepository, CoachOfTrainingsRepository>();
            services.AddScoped<IParticipantsRepository, ParticipantsRepository>();
            services.AddScoped<IParticipantOfTrainingsRepository, ParticipantOfTrainingsRepository>();
            services.AddScoped<ITrainingsRepository, TrainingsRepository>();
            services.AddScoped<ITrainingTypesRepository, TrainingTypesRepository>();

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
