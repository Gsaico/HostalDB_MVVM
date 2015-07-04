using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Role
{
   [ServiceContract]
   public interface IRoleService
    {
      
        [OperationContract]
        int InsertarRol(Dominio.Dtos.roleDTO dto);
        [OperationContract]
        bool ActualizarRol(Dominio.Dtos.roleDTO dto);
        [OperationContract]
        bool EliminarRol(int id);
        [OperationContract]
        List<Dominio.Dtos.roleDTO> BuscarRolPorNombre(string ParametroNombreRol);
        [OperationContract]
        List<Dominio.Dtos.roleDTO> ListarTodosLosRoles();
        [OperationContract]
        Dominio.Dtos.roleDTO BuscarRolPorID(int ParametroIDrol);
    }
}
