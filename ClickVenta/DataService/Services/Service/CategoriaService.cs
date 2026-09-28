using AutoMapper;
using BusinessEntities.Dtos.Categoria;
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
    public class CategoriaService : ICategoriaService

    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateCategoria(CreateCategoriaDto categoriaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", categoriaDto.Nombre),
                    new SqlParameter("@Descripcion", categoriaDto.Descripcion),
                    new SqlParameter("@FechaCreacion", categoriaDto.FechaCreacion),
                    new SqlParameter("@FechaBaja", categoriaDto.FechaBaja),
                    new SqlParameter("@Estado", categoriaDto.Estado),
                    //new SqlParameter("@Productos", categoriaDto.Productos)
                };
                var categoria = _mapper.Map<BusinessEntities.Entities.Categoria>(categoriaDto);
                await this._categoriaRepository.Create("[dbo].[Sp_InsertCategoria]", parameters);
                return "Categoria creada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteCategoria(DeleteCategoriaDto categoriaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", categoriaDto.Id)
                };
                await this._categoriaRepository.Delete("[dbo].[Sp_DeleteCategoria]", parameters);
                return "Categoria eliminada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<CategoriaDto>> GetAllCategorias(int state, int page, int pageSize, string filter = null)
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
                var categorias = await this._categoriaRepository.GetAll("[dbo].[Sp_GetAllCategorias]", parameters);
                return _mapper.Map<IEnumerable<CategoriaDto>>(categorias);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<CategoriaDto> GetCategoriaById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var categoria = await this._categoriaRepository.GetById("[dbo].[Sp_GetCategoriaById]", parameters);
                return _mapper.Map<CategoriaDto>(categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> UpdateCategoria(UpdateCategoriaDto categoriaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", categoriaDto.Nombre),
                    new SqlParameter("@Descripcion", categoriaDto.Descripcion),
                    new SqlParameter("@FechaCreacion", categoriaDto.FechaCreacion),
                    new SqlParameter("@FechaBaja", categoriaDto.FechaBaja),
                    new SqlParameter("@Estado", categoriaDto.Estado),
                    //new SqlParameter("@Productos", categoriaDto.Productos)
                };
                var categoria = _mapper.Map<BusinessEntities.Entities.Categoria>(categoriaDto);
                await this._categoriaRepository.Update("[dbo].[Sp_UpdateCategoria]", parameters);
                return "Categoria actualizada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
