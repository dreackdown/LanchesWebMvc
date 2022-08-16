using Microsoft.EntityFrameworkCore;
using RestaurantWebMvc.Context;
using RestaurantWebMvc.Models;
using RestaurantWebMvc.Repositories;
using RestaurantWebMvc.Repositories.Interfaces;

namespace RestaurantWebMvc
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
            var connectionString = Configuration.GetConnectionString("RestaurantCs");
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

            services.AddTransient<ILancheRepository, LancheRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            //Instacia p vida da aplicacao
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //A cada request
            services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

            services.AddControllersWithViews();

            services.AddMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "categoriaFiltro",
                    pattern: "Lanche/{action}/{categoria?}",
                    defaults: new { Controller = "Lanche", action = "List" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
