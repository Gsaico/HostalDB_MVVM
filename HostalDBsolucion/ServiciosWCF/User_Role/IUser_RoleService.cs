using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.User_Role
{
   [ServiceContract]
   public interface IUser_RoleService
    {
        
        [OperationContract]
        int InsertarUserRole(Dominio.Dtos.user_roleDTO dto);
       [OperationContract]
        bool ActualizarUserRole(Dominio.Dtos.user_roleDTO dto);
       [OperationContract]
        bool EliminarUserRole(int IDUSERROLparametro);
       [OperationContract]
        List<Dominio.Dtos.user_roleDTO> ListarUserRolePorIDUSER(int IDUSERparametro);
       [OperationContract]
        List<Dominio.Dtos.user_roleDTO> ListarUserRolePorIDROL(int IDROLparametro);
       [OperationContract]
        Dominio.Dtos.user_roleDTO BuscarUserRolePorIDUSER(int IDUSERparametro);
       [OperationContract]
        Dominio.Dtos.user_roleDTO BuscarUserRolePorIDROL(int IDROLparametro);
       [OperationContract]
        List<Dominio.Querys.Querys.ListarRolesDelUsuarioClass> ListarRolesDelUsuario(int IDUSERparametro);

    }
}
