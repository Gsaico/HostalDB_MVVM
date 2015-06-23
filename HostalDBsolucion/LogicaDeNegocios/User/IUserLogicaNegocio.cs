using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.User
{
    public interface IUserLogicaNegocio
    {
        int InsertarUsuario(Dominio.Dtos.userDTO  dto);
        bool ActualizarUsuario(Dominio.Dtos.userDTO dto);
        bool EliminarUsuario(int id);
        List<Dominio.Dtos.userDTO> BuscarUsuario(string parametro);
        List<Dominio.Dtos.userDTO> ListarUsuarios();
    }
}
