using ClickVenta.forms;
using ClickVenta.forms.Empleado;
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
                    services.AddTransient<frmpermission>();
                    services.AddTransient<frmempleado>();
                    //services.AddTransient<frmrol>();
                    //services.AddTransient<frmproducto>();
                    //services.AddTransient<frmcategoria>();

                    //Aqui se inyecta los interfaces de los repositorios genericos
                    services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


                    // Aquí se inyecta los interfaces de los repositorios
                    services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
                    services.AddScoped<IProveedorRepository, ProveedorRepository>();
                    services.AddScoped<IProductoRepository, ProductoRepository>();
                    services.AddScoped<ICategoriaRepository, CategoriaRepository>();
                    services.AddScoped<ITipoMovimientoRepository, TipoMovimientoRepository>();
                    services.AddScoped<IMovimientoRepository, MovimientoRepository>();
                    services.AddScoped<IRolRepository, RolRepository>();
                    services.AddScoped<IFormaPagoRepository, FormaPagoRepository>();
                    services.AddScoped<IDetallePagoRepository, DetallePagoRepository>();

                    services.AddScoped<IPermissionRepository, PermissionRepository>();
                    services.AddScoped<IUsuarioRepository, UsuarioRepository>();
                    services.AddScoped<IRolRepository, RolRepository>();

                    // Aquí se inyecta los interfaces de los servicios
                    services.AddScoped<IEmpleadoService, EmpleadoService>();
                    services.AddScoped<IProveedorService, ProveedorService>();
                    services.AddScoped<IProductoService, ProductoService>();
                    services.AddScoped<ICategoriaService, CategoriaService>();
                    services.AddScoped<ITipoMovimientoService, TipoMovimientoService>();
                    services.AddScoped<IMovimientoService, MovimientoService>();
                    services.AddScoped<IRolService, RolService>();
                    services.AddScoped<IFormaPagoService, FormaPagoService>();
                    services.AddScoped<IDetallePagoService, DetallePagoService>();

                    services.AddScoped<IPermissionService, PermissionService>();
                    services.AddScoped<IUsuarioService, UsuarioService>();
                    services.AddScoped<IRolService, RolService>();
                    services.AddScoped<ILoginService, LoginService>();

                    //Aqui se inyecta el automapper
                    services.AddAutoMapper(auto => auto.AddProfile<ClickVentaProfile>());
                });
        }
    }
}
