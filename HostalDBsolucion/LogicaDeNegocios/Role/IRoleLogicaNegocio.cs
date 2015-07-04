using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Role
{
    public interface IRoleLogicaNegocio
    {
        int InsertarRol(Dominio.Dtos.roleDTO dto);
        bool ActualizarRol(Dominio.Dtos.roleDTO dto);
        bool EliminarRol(int id);
        List<Dominio.Dtos.roleDTO> BuscarRolPorNombre(string ParametroNombreRol);
        List<Dominio.Dtos.roleDTO> ListarTodosLosRoles();
        Dominio.Dtos.roleDTO BuscarRolPorID(int ParametroIDrol);
    }
}
