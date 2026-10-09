using AutoMapper;
using BusinessEntities.Dtos.Login;
using DataService.Services.IService;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Resolver.Security.Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.Service
{
    public class LoginService : ILoginService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public LoginService(IUsuarioRepository usuarioRepository, IMapper mapper, IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<string> CambiarPassword(LoginDto dto)
        {
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[] 
                {
                    new SqlParameter("@UsuarioLogin", dto.UsuarioLogin),
                    new SqlParameter("@Password", dto.Password)
                };
                var result = await _usuarioRepository.Update("[dbo].[sp_CambiarPassword]", sqlParameter);
                return "La contraseña se ha cambiado correctamente.";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<LoginReturnDto> Login(LoginDto dto)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@UsuarioLogin", dto.UsuarioLogin),
                    new SqlParameter("@Password", PasswordEncryptor.GetInstance().Encypt(dto.Password))
                };
                var result = await _usuarioRepository.GetById("[dbo].[sp_Login]", sqlParameters);
                return _mapper.Map<LoginReturnDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
