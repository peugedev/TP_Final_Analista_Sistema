using AutoMapper;
using BusinessEntities.Dtos.Categoria;
using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.Login;
using BusinessEntities.Dtos.Lote;
using BusinessEntities.Dtos.permision;
using BusinessEntities.Dtos.Presentacion;
using BusinessEntities.Dtos.Producto;
using BusinessEntities.Dtos.Proveedor;
using BusinessEntities.Dtos.Rol;
using BusinessEntities.Entities;

namespace DataService.Profiles
{
    public class ClickVentaProfile: Profile
    {
        public ClickVentaProfile()
        {
            #region Empleado
            CreateMap<Empleado, CreateEmpleadoDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BusinessEntities.Entities.Empleado, UpdateEmpleadoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Empleado, DeleteEmpleadoDto>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Empleado, EmpleadoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            #endregion

            #region Rol
            CreateMap<Rol, CreateRolDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ReverseMap();
            CreateMap<Rol, UpdateRolDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ReverseMap();
            CreateMap<Rol, DeleteRolDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<Rol, RolDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ReverseMap();
            #endregion

            #region Permiso y Usuario
            CreateMap<Usuario, LoginReturnDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.EmpleadoId, opt => opt.MapFrom(src => src.EmpleadoId))
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.NombreUsuario))
                .ForMember(dest => dest.RolId, opt => opt.MapFrom(src => src.RolId))
                .ReverseMap();
            CreateMap<PermissionMenu, PermissionMenuDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.SubMenuId, opt => opt.MapFrom(src => src.SubMenuId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.SubMenuName, opt => opt.MapFrom(src => src.SubMenuName))
                .ForMember(dest => dest.IsAssigned, opt => opt.MapFrom(src => src.IsAssigned))
                .ForMember(dest => dest.FormAssociation, opt => opt.MapFrom(src => src.formAssociation))
                .ReverseMap();
            #endregion

            #region Categoria
            CreateMap<BusinessEntities.Entities.Categoria, CategoriaDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Categoria, CreateCategoriaDto>()
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Categoria, UpdateCategoriaDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap();


            CreateMap<BusinessEntities.Entities.Categoria, DeleteCategoriaDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();
            #endregion

            #region Presentacion
            CreateMap<Presentacion, PresentacionDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom( src => src.Id))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap();

            CreateMap<Presentacion, UpdatePresentacionDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap();

            CreateMap<Presentacion, CreatePresentacionDto>()
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap();

            CreateMap<Presentacion, DeletePresentacionDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();
            #endregion

            #region Producto
            CreateMap<Producto, ProductoDto>()
                .ForMember( dest => dest.Id, opt => opt.MapFrom( src => src.Id))
                .ForMember(dest => dest.CategoriaId, opt => opt.MapFrom(src => src.CategoriaId))
                .ForMember(dest => dest.ProveedorProductoId, opt => opt.MapFrom(src => src.ProveedorId))
                .ForMember(dest => dest.PresentacionId, opt => opt.MapFrom(src => src.PresentacionId))
                .ForMember(dest => dest.CodigoBarra, opt => opt.MapFrom(src => src.CodigoBarra))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.CodigoBarra))
                .ForMember(dest => dest.PrecioCompra, opt => opt.MapFrom(src => src.PrecioCompra))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ReverseMap();

            CreateMap<Producto, CreateProductoDto>()
                .ForMember(dest => dest.CategoriaId, opt => opt.MapFrom(src => src.CategoriaId))
                .ForMember(dest => dest.PresentacionId, opt => opt.MapFrom(src => src.PresentacionId))
                .ForMember(dest => dest.ProveedorId, opt => opt.MapFrom(src => src.ProveedorId))
                .ForMember(dest => dest.CodigoBarra, opt => opt.MapFrom(src => src.CodigoBarra))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.CodigoBarra))
                .ForMember(dest => dest.PrecioCompra, opt => opt.MapFrom(src => src.PrecioCompra))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ReverseMap();

            CreateMap<Producto, UpdateProductoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CategoriaId, opt => opt.MapFrom(src => src.CategoriaId))
                .ForMember(dest => dest.PresentacionId, opt => opt.MapFrom(src => src.PresentacionId))
                .ForMember(dest => dest.ProveedorProductoId, opt => opt.MapFrom(src => src.ProveedorId))
                .ForMember(dest => dest.CodigoBarra, opt => opt.MapFrom(src => src.CodigoBarra))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.CodigoBarra))
                .ForMember(dest => dest.PrecioCompra, opt => opt.MapFrom(src => src.PrecioCompra))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ReverseMap();

            CreateMap<Producto, DeleteProductoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();
            #endregion

            #region Lote
            CreateMap<BusinessEntities.Entities.Lote, LoteDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProductoId, opt => opt.MapFrom(src => src.ProductoId))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ForMember(dest => dest.PrecioCompra, opt => opt.MapFrom(src => src.PrecioCompra))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.FechaVencimiento, opt => opt.MapFrom(src => src.FechaVencimiento))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Lote, CreateLoteDto>()
                .ForMember(dest => dest.ProductoId, opt => opt.MapFrom(src => src.ProductoId))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ForMember(dest => dest.PrecioCompra, opt => opt.MapFrom(src => src.PrecioCompra))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.FechaVencimiento, opt => opt.MapFrom(src => src.FechaVencimiento))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Lote, UpdateLoteDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProductoId, opt => opt.MapFrom(src => src.ProductoId))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ForMember(dest => dest.PrecioCompra, opt => opt.MapFrom(src => src.PrecioCompra))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.FechaVencimiento, opt => opt.MapFrom(src => src.FechaVencimiento))
                .ReverseMap();


            CreateMap<BusinessEntities.Entities.Lote, DeleteLoteDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();
            #endregion

            #region Proveedor
            CreateMap<BusinessEntities.Entities.Proveedor, ProveedorDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src.Count))
                .ForMember(dest => dest.RazonSocial, opt => opt.MapFrom(src => src.RazonSocial))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ReverseMap();
            #endregion
        }
    }
}
