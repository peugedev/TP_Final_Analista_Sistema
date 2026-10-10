using AutoMapper;
using BusinessEntities.Dtos.Presentacion;
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
    public class PresentacionService : IPresentacionService
    {
        private readonly IPresentacionRepository _presentacionRepository;
        private readonly IMapper _mapper;

        public PresentacionService(IPresentacionRepository presentacionRepository, IMapper mapper)
        {
            _presentacionRepository = presentacionRepository;
            _mapper = mapper;
        }

        public async Task<string> CreatePresentacion(CreatePresentacionDto presentacionDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", presentacionDto.Nombre),
                    new SqlParameter("@Descripcion", presentacionDto.Descripcion)
                };

                var entity = _mapper.Map<BusinessEntities.Entities.Presentacion>(presentacionDto);
                await this._presentacionRepository.Create("[dbo].[Sp_InsertPresentacion]", parameters);
                return "Presentacion creada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> DeletePresentacion(DeletePresentacionDto presentacionDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", presentacionDto.Id)
                };
                await this._presentacionRepository.Delete("[dbo].[Sp_DeletePresentacion]", parameters);
                return "Presentacion eliminada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PresentacionDto>> GetAllPresentaciones(int state, int page, int pageSize, string filter = null)
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
                var items = await this._presentacionRepository.GetAll("[dbo].[Sp_GetAllPresentaciones]", parameters);
                return _mapper.Map<IEnumerable<PresentacionDto>>(items);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<PresentacionDto> GetPresentacionById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var item = await this._presentacionRepository.GetById("[dbo].[Sp_GetPresentacionById]", parameters);
                return _mapper.Map<PresentacionDto>(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UpdatePresentacion(UpdatePresentacionDto presentacionDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", presentacionDto.Id),
                    new SqlParameter("@Nombre", presentacionDto.Nombre),
                    new SqlParameter("@Descripcion", presentacionDto.Descripcion)
                };

                var entity = _mapper.Map<BusinessEntities.Entities.Presentacion>(presentacionDto);
                await this._presentacionRepository.Update("[dbo].[Sp_UpdatePresentacion]", parameters);
                return "Presentacion actualizada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
