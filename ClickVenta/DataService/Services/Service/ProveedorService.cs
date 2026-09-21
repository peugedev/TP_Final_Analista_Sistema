using AutoMapper;
using BusinessEntities.Dtos.Proveedor;
using DataService.Services.IService;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;

namespace DataService.Services.Service
{
    public class ProveedorService: IProveedorService
    {
        private readonly IProveedorRepository _proveedorRepository;
        private readonly IMapper _mapper;

        public ProveedorService(IProveedorRepository proveedorRepository, IMapper mapper)
        {
            _proveedorRepository = proveedorRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateProveedor(CreateProveedorDto proveedorDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Codigo", proveedorDto.Codigo),
                    new SqlParameter("@Cuit_Cuil", proveedorDto.Cuit_Cuil),
                    new SqlParameter("@RazonSocial", proveedorDto.RazonSocial),
                    new SqlParameter("@Email", proveedorDto.Email),
                    new SqlParameter("@Telefono", proveedorDto.Telefono),
                    new SqlParameter("@Direccion", proveedorDto.Direccion),
                    new SqlParameter("@Web", proveedorDto.Web)
                };
                var proveedor = _mapper.Map<BusinessEntities.Entities.Proveedor>(proveedorDto);
                await this._proveedorRepository.Create("[dbo].[Sp_InsertProveedor]", parameters);
                return "Proveedor creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteProveedor(DeleteProveedorDto proveedorDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", proveedorDto.Id)
                };
                await this._proveedorRepository.Delete("[dbo].[Sp_DeleteProveedor]", parameters);
                return "Proveedor eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<ProveedorDto>> GetAllProveedores(int state, int page, int pageSize, string filter = null)
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
                var proveedores = await this._proveedorRepository.GetAll("[dbo].[Sp_GetAllProveedores]", parameters);
                return _mapper.Map<IEnumerable<ProveedorDto>>(proveedores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ProveedorDto> GetProveedorById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var proveedor = await this._proveedorRepository.GetById("[dbo].[Sp_GetProveedorById]", parameters);
                return _mapper.Map<ProveedorDto>(proveedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> UpdateProveedor(UpdateProveedorDto proveedorDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Codigo", proveedorDto.Codigo),
                    new SqlParameter("@Cuit_Cuil", proveedorDto.Cuit_Cuil),
                    new SqlParameter("@RazonSocial", proveedorDto.RazonSocial),
                    new SqlParameter("@Email", proveedorDto.Email),
                    new SqlParameter("@Telefono", proveedorDto.Telefono),
                    new SqlParameter("@Direccion", proveedorDto.Direccion),
                    new SqlParameter("@Web", proveedorDto.Web)
                };
                var proveedor = _mapper.Map<BusinessEntities.Entities.Proveedor>(proveedorDto);
                await this._proveedorRepository.Update("[dbo].[Sp_UpdateProveedor]", parameters);
                return "Proveedor actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
