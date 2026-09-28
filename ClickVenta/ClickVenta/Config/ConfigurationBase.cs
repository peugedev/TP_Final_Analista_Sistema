using DataService.Profiles;
using DataService.Services.IService;
using DataService.Services.Service;
using DomainModel.GenericRepository.Generic;
using DomainModel.GenericRepository.IGeneric;
using DomainModel.Repositories.Interface;
using DomainModel.Repositories.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickVenta.Config
{
    public class ConfigurationBase
    {
        public static IConfiguration Configuration { get; private set; }

        public static IHostBuilder CreateHostBuilter() 
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((hostingContext, services) =>
                {
                    var builder = new ConfigurationBuilder()
                     .AddJsonFile("appsetting.json", optional: false, reloadOnChange: true);

                    Configuration = builder.Build();   
                    services.AddSingleton(Configuration);

                    //Aqui se inyecta los formulario
                    services.AddTransient<frmlogin>(); 

                    //Aqui se inyecta los interfaces de los repositorios genericos
                    services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


                    // Aquí se inyecta los interfaces de los repositorios
                    services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
                    services.AddScoped<IPermissionRepository, PermissionRepository>();
                    services.AddScoped<IUsuarioRepository, UsuarioRepository>();

                    // Aquí se inyecta los interfaces de los servicios
                    services.AddScoped<IEmpleadoService, EmpleadoService>();
                    services.AddScoped<IPermissionService, PermissionService>();
                    services.AddScoped<IUsuarioService, UsuarioService>();

                    //Aqui se inyecta el automapper
                    services.AddAutoMapper(auto => auto.AddProfile<ClickVentaProfile>());
                });
        }
    }
}
