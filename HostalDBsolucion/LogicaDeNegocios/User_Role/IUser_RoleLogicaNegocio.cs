using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Collections;

namespace LogicaDeNegocios.User_Role
{
    public interface IUser_RoleLogicaNegocio
    {

        int InsertarUserRole(Dominio.Dtos.user_roleDTO dto);
        bool ActualizarUserRole(Dominio.Dtos.user_roleDTO dto);
        bool EliminarUserRole(int IDUSERROLparametro);
        List<Dominio.Dtos.user_roleDTO> ListarUserRolePorIDUSER(int IDUSERparametro);
        List<Dominio.Dtos.user_roleDTO> ListarUserRolePorIDROL(int IDROLparametro);
        Dominio.Dtos.user_roleDTO BuscarUserRolePorIDUSER(int IDUSERparametro);
        Dominio.Dtos.user_roleDTO BuscarUserRolePorIDROL(int IDROLparametro);
        List<Dominio.Querys.Querys.ListarRolesDelUsuarioClass> ListarRolesDelUsuario(int IDUSERparametro);
       

    }
}
