using AutoMapper;
using BusinessEntities.Dtos.ProveedorProducto;
using DataService.Services.IService;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.Service
{
    public class ProveedorProductoService : IProveedorProductoService
    {
        private readonly IProveedorProductoRepository _repo;
        private readonly IMapper _mapper;

        public ProveedorProductoService(IProveedorProductoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<string> CreateProveedorProducto(CreateProveedorProductoDto dto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ProveedorId", dto.ProveedorId),
                    new SqlParameter("@ProductoId", dto.ProductoId)
                };
                var entity = _mapper.Map<BusinessEntities.Entities.ProveedorProducto>(dto);
                await this._repo.Create("[dbo].[Sp_InsertProveedorProducto]", parameters);
                return "ProveedorProducto creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> DeleteProveedorProducto(DeleteProveedorProductoDto dto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@Id", dto.Id) };
                await this._repo.Delete("[dbo].[Sp_DeleteProveedorProducto]", parameters);
                return "ProveedorProducto eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<ProveedorProductoDto>> GetAllProveedorProductos(int state, int page, int pageSize, string filter = null)
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
                var items = await this._repo.GetAll("[dbo].[Sp_GetAllProveedorProductos]", parameters);
                return _mapper.Map<IEnumerable<ProveedorProductoDto>>(items);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ProveedorProductoDto> GetProveedorProductoById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@Id", id) };
                var item = await this._repo.GetById("[dbo].[Sp_GetProveedorProductoById]", parameters);
                return _mapper.Map<ProveedorProductoDto>(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UpdateProveedorProducto(UpdateProveedorProductoDto dto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", dto.Id),
                    new SqlParameter("@ProveedorId", dto.ProveedorId),
                    new SqlParameter("@ProductoId", dto.ProductoId)
                };
                var entity = _mapper.Map<BusinessEntities.Entities.ProveedorProducto>(dto);
                await this._repo.Update("[dbo].[Sp_UpdateProveedorProducto]", parameters);
                return "ProveedorProducto actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
