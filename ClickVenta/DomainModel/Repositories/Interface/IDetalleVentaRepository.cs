using BusinessEntities.Entities;
using DomainModel.GenericRepository.IGeneric;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repositories.Interface
{
    public interface IDetalleVentaRepository : IGenericRepository<DetalleVenta>
    {
        Task<IEnumerable<DetalleVenta>> GetAllDetalleVentaById(string query, SqlParameter[] parameters, CancellationToken ct = default);
    }
}
