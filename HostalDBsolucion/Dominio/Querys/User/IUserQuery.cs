using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.User
{
   public interface IUserQuery
    {
        int InsertarUsuario(Dtos.userDTO  dto);
        bool ActualizarUsuario(Dtos.userDTO dto);
        bool EliminarUsuario(int id);
        List<Dtos.userDTO> BuscarUsuario(string parametro);
        List<Dtos.userDTO> ListarUsuarios();
    }
}
