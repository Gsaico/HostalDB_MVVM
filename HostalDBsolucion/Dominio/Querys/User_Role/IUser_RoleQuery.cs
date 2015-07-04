using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;
using System.Collections;

namespace Dominio.Querys.User_Role
{
    public interface IUser_RoleQuery
    {
        int InsertarUserRole(Dtos.user_roleDTO    dto);
        bool ActualizarUserRole(Dtos.user_roleDTO dto);
        bool EliminarUserRole(int IDUSERROLparametro);
        List<Dtos.user_roleDTO> ListarUserRolePorIDUSER(int IDUSERparametro);
        List<Dtos.user_roleDTO> ListarUserRolePorIDROL(int IDROLparametro);
        Dtos.user_roleDTO BuscarUserRolePorIDUSER(int IDUSERparametro);
        Dtos.user_roleDTO BuscarUserRolePorIDROL(int IDROLparametro);
        List<Dominio.Querys.Querys.ListarRolesDelUsuarioClass> ListarRolesDelUsuario(int IDUSERparametro);
       
    }
}
