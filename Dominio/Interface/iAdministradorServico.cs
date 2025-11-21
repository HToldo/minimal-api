using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interface;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
}
