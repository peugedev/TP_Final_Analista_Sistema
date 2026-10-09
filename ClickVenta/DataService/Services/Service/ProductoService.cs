using AutoMapper;
using BusinessEntities.Dtos.Producto;
using DataService.Services.IService;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;

namespace DataService.Services.Service
{
    public class ProductoService: IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateProducto(CreateProductoDto productoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", productoDto.Descripcion),
                    new SqlParameter("@CodigoBarra", productoDto.CodigoBarra),
                    new SqlParameter("@Nombre", productoDto.Nombre),
                    new SqlParameter("@PrecioCompra", productoDto.PrecioCompra),
                    new SqlParameter("@IdCategoria", productoDto.IdCategoria)
                };
                var producto = _mapper.Map<BusinessEntities.Entities.Producto>(productoDto);
                await this._productoRepository.Create("[dbo].[Sp_InsertProducto]", parameters);
                return "Producto creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteProducto(DeleteProductoDto productoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", productoDto.Id)
                };
                await this._productoRepository.Delete("[dbo].[Sp_DeleteProducto]", parameters);
                return "Producto eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<ProductoDto>> GetAllProductos(int state, int page, int pageSize, string filter = null)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@State", state),
                    new SqlParameter("@Page", page),
                    new SqlParameter("@PageSize", pageSize),
                    new SqlParameter("@Filter", filter ?? (object)DBNull.Value)
                };
                var productos = await this._productoRepository.GetAll("[dbo].[Sp_GetAllProductos]", parameters);
                return _mapper.Map<IEnumerable<ProductoDto>>(productos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ProductoDto> GetProductoById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var producto = await this._productoRepository.GetById("[dbo].[Sp_GetProductoById]", parameters);
                return _mapper.Map<ProductoDto>(producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> UpdateProducto(UpdateProductoDto productoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", productoDto.Descripcion),
                    new SqlParameter("@CodigoBarra", productoDto.CodigoBarra),
                    new SqlParameter("@Nombre", productoDto.Nombre),
                    new SqlParameter("@PrecioCompra", productoDto.PrecioCompra),
                    new SqlParameter("@IdCategoria", productoDto.IdCategoria)
                };
                var producto = _mapper.Map<BusinessEntities.Entities.Producto>(productoDto);
                await this._productoRepository.Update("[dbo].[Sp_UpdateProducto]", parameters);
                return "Producto actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
