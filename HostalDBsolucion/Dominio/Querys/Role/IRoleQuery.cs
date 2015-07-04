using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Role
{
   public interface IRoleQuery
    {
        int InsertarRol(Dtos.roleDTO   dto);
        bool ActualizarRol(Dtos.roleDTO dto);
        bool EliminarRol(int id);
        List<Dtos.roleDTO> BuscarRolPorNombre(string ParametroNombreRol);
        List<Dtos.roleDTO> ListarTodosLosRoles();
        Dtos.roleDTO BuscarRolPorID(int ParametroIDrol);
    }
}
