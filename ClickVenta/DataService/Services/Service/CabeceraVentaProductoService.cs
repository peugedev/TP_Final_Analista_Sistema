using AutoMapper;
using BusinessEntities.Dtos;
using BusinessEntities.Dtos.Cabecera;
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
    public class CabeceraVentaProductoService : ICabeceraVentaProductoService
    {
        private readonly ICabeceraVentaProductoRepository _cabeceraVentaRepository;
        private readonly IMapper _mapper;

        public CabeceraVentaProductoService(ICabeceraVentaProductoRepository cabeceraVentaRepository, IMapper mapper)
        {
            _cabeceraVentaRepository = cabeceraVentaRepository;
            _mapper = mapper;
        }

        public async Task<ConsultaProductoCodigoBarraDto> ConsultaProductoCodigo(string codigo)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@code", codigo)
                };
                var result = await _cabeceraVentaRepository.GetById("[dbo].[SP_GetProductoByCodigoBara]", sqlParameters);
                return _mapper.Map<ConsultaProductoCodigoBarraDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CabeceraVentaDto> GetCabecera()
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                };
                var result = await _cabeceraVentaRepository.GetById("[dbo].[sp_Getdetallecabeceraventa]", parameters);
                return _mapper.Map<CabeceraVentaDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
