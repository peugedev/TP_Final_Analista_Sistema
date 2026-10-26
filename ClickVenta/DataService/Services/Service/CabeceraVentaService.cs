using AutoMapper;
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
    public class CabeceraVentaService : ICabeceraVentaService
    {
        private readonly ICabeceraVentaRepository _cabeceraVentaRepository;
        private readonly IMapper _mapper;

        public CabeceraVentaService(ICabeceraVentaRepository cabeceraVentaRepository, IMapper mapper)
        {
            _cabeceraVentaRepository = cabeceraVentaRepository;
            _mapper = mapper;
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
