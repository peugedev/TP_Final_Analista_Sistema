using ClickVenta.forms;
using ClickVenta.forms.Empleado;
using ClickVenta.forms.ventas;
using DataService.Profiles;
using DataService.Services.IService;
using DataService.Services.Service;
using DomainModel.Connection.Data;
using DomainModel.GenericRepository.Generic;
using DomainModel.GenericRepository.IGeneric;
using DomainModel.Repositories.Interface;
using DomainModel.Repositories.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ClickVenta.Config
{
    public static class ConfigurationBase
    {
        public static IConfiguration Configuration { get; private set; }

        public static IHostBuilder CreateHostBuilter() 
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(AppContext.BaseDirectory);
                    var builder = config.AddJsonFile("appsetting.json", optional: false, reloadOnChange: true);

                    // Opcional: override por entorno (Development, Production, etc.)
                    //var env = context.HostingEnvironment;
                    //config.AddJsonFile($"appsetting.{env.EnvironmentName}.json",
                    //                   optional: true, reloadOnChange: true);
                    Configuration = builder.Build();

                })
                .ConfigureServices(static (context, services) =>
                {
                    services.AddSingleton<IConfiguration>(Configuration);
                    services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                    // 2) Fábrica de conexiones (scoped)
                    services.AddSqlConnectionFactory();

                    // 3) Repositorios (scoped)
                    services.AddRepositories(
                        //typeof(IGenericRepository<>), typeof(GenericRepository<>),
                        typeof(IProductoRepository), typeof(ProductoRepository),
                        typeof(ILoteRepository), typeof(LoteRepository),
                        typeof(IProveedorRepository), typeof(ProveedorRepository),
                        typeof(ICategoriaRepository), typeof(CategoriaRepository),
                        typeof(ITipoMovimientoRepository), typeof(TipoMovimientoRepository),
                        typeof(IMovimientoRepository), typeof(MovimientoRepository),
                        typeof(IRolRepository), typeof(RolRepository),
                        typeof(IFormaPagoRepository), typeof(FormaPagoRepository),
                        typeof(IDetallePagoRepository), typeof(DetallePagoRepository),
                        typeof(IVentaRepository), typeof(VentaRepository),
                        typeof(IDetalleVentaRepository), typeof(DetalleVentaRepository),
                        typeof(IPresentacionRepository), typeof(PresentacionRepository),
                        typeof(IProveedorProductoRepository), typeof(ProveedorProductoRepository),
                        typeof(IPermissionRepository), typeof(PermissionRepository),
                        typeof(IUsuarioRepository), typeof(UsuarioRepository),
                        typeof(IEmpleadoRepository), typeof(EmpleadoRepository),
                        typeof(ICabeceraVentaRepository), typeof(CabeceraVentaRepository),

                        /* Aqui se inyecta los servicios*/
                        typeof(IEmpleadoService), typeof(EmpleadoService),
                        typeof(IProveedorService), typeof(ProveedorService),
                        typeof(IProductoService), typeof(ProductoService),
                        typeof(ICategoriaService), typeof(CategoriaService),
                        typeof(ITipoMovimientoService), typeof(TipoMovimientoService),
                        typeof(IMovimientoService), typeof(MovimientoService),
                        typeof(IRolService), typeof(RolService),
                        typeof(IFormaPagoService), typeof(FormaPagoService),
                        typeof(IDetallePagoService), typeof(DetallePagoService),
                        typeof(IVentaService), typeof(VentaService),
                        typeof(IDetalleVentaService), typeof(DetalleVentaService),
                        typeof(IPresentacionService), typeof(PresentacionService),
                        typeof(ILoteService), typeof(LoteService),
                        typeof(IProveedorProductoService), typeof(ProveedorProductoService),
                        typeof(IPermissionService), typeof(PermissionService),
                        typeof(IUsuarioService), typeof(UsuarioService),
                        typeof(ILoginService), typeof(LoginService),
                        typeof(ICabeceraVentaService), typeof(CabeceraVentaService)
                    );

                    //Aqui se inyecta los formulario
                    services.AddTransient<frmlogin>();
                    services.AddTransient<frmpermission>();
                    services.AddTransient<frmempleado>();
                    services.AddTransient<frmventa>();
                    //services.AddTransient<frmproducto>();
                    //services.AddTransient<frmcategoria>();

                    

                    //Aqui se inyecta el automapper
                    services.AddAutoMapper(auto => auto.AddProfile<ClickVentaProfile>());
                });
        }
    }
}
