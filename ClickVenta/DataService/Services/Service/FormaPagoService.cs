using AutoMapper;
using BusinessEntities.Dtos.FormaPago;
using BusinessEntities.Dtos.Producto;
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
    public class FormaPagoService : IFormaPagoService
    {
        private readonly IFormaPagoRepository _formaPagoRepository;
        private readonly IMapper _mapper;

        public FormaPagoService(IFormaPagoRepository formaPagoRepository, IMapper mapper)
        {
            _formaPagoRepository = formaPagoRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateFormaPago(CreateFormaPagoDto formaPagoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", formaPagoDto.Descripcion),
                    new SqlParameter("@Nombre", formaPagoDto.Nombre)
                };
                var formaPago = _mapper.Map<BusinessEntities.Entities.FormaPago>(formaPagoDto);
                await this._formaPagoRepository.Create("[dbo].[Sp_InsertFormaPago]", parameters);
                return "Forma de pago creada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteFormaPago(DeleteFormaPagoDto formaPagoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", formaPagoDto.Id)
                };
                await this._formaPagoRepository.Delete("[dbo].[Sp_DeleteFormaPago]", parameters);
                return "Forma de pago eliminada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<FormaPagoDto>> GetAllFormasPago(int state, int page, int pageSize, string filter = null)
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
                var formasPago = await this._formaPagoRepository.GetAll("[dbo].[Sp_GetAllFormasPago]", parameters);
                return _mapper.Map<IEnumerable<FormaPagoDto>>(formasPago);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<FormaPagoDto> GetFormaPagoById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var formaPago = await this._formaPagoRepository.GetById("[dbo].[Sp_GetFormaPagoById]", parameters);
                return _mapper.Map<FormaPagoDto>(formaPago);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> UpdateFormaPago(UpdateFormaPagoDto formaPagoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", formaPagoDto.Descripcion),
                    new SqlParameter("@Nombre", formaPagoDto.Nombre)
                };
                var formaPago = _mapper.Map<BusinessEntities.Entities.FormaPago>(formaPagoDto);
                await this._formaPagoRepository.Update("[dbo].[Sp_UpdateFormaPago]", parameters);
                return "Forma de pago actualizada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
