using AutoMapper;
using BusinessEntities.Dtos.DetallePago;
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
    public class DetallePagoService : IDetallePagoService
    {
        private readonly IDetallePagoRepository _detallePagoRepository;
        private readonly IMapper _mapper;

        public DetallePagoService(IDetallePagoRepository detallePagoRepository, IMapper mapper)
        {
            _detallePagoRepository = detallePagoRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateDetallePago(CreateDetallePagoDto detallePagoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IdVenta", detallePagoDto.IdVenta),
                    new SqlParameter("@IdFormaPago", detallePagoDto.IdFormaPago),
                    new SqlParameter("@Observaciones", detallePagoDto.Observaciones)
                };
                var detallePago = _mapper.Map<BusinessEntities.Entities.DetallePago>(detallePagoDto);
                await this._detallePagoRepository.Create("[dbo].[Sp_InsertDetallePago]", parameters);
                return "DetallePago creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteDetallePago(DeleteDetallePagoDto detallePagoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", detallePagoDto.Id)
                };
                await this._detallePagoRepository.Delete("[dbo].[Sp_DeleteDetallePago]", parameters);
                return "DetallePago eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<DetallePagoDto>> GetAllDetallePagos(int state, int page, int pageSize, string filter = null)
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
                var detallePagos = await this._detallePagoRepository.GetAll("[dbo].[Sp_GetAllDetallePagos]", parameters);
                return _mapper.Map<IEnumerable<DetallePagoDto>>(detallePagos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<DetallePagoDto> GetDetallePagoById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var detallePago = await this._detallePagoRepository.GetById("[dbo].[Sp_GetDetallePagoById]", parameters);
                return _mapper.Map<DetallePagoDto>(detallePago);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> UpdateDetallePago(UpdateDetallePagoDto detallePagoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IdVenta", detallePagoDto.IdVenta),
                    new SqlParameter("@IdFormaPago", detallePagoDto.IdFormaPago),
                    new SqlParameter("@Observaciones", detallePagoDto.Observaciones)
                };
                var detallePago = _mapper.Map<BusinessEntities.Entities.DetallePago>(detallePagoDto);
                await this._detallePagoRepository.Update("[dbo].[Sp_UpdateDetallePago]", parameters);
                return "DetallePago actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
