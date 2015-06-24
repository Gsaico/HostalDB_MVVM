using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.User
{
   [ServiceContract]
   public interface IUserService
    {
        [OperationContract]
        int InsertarUsuario(Dominio.Dtos.userDTO   dto);
        [OperationContract]
        bool ActualizarUsuario(Dominio.Dtos.userDTO dto);
        [OperationContract]
        bool EliminarUsuario(int id);
        [OperationContract]
        List<Dominio.Dtos.userDTO> BuscarUsuario(string parametro);
        [OperationContract]
        List<Dominio.Dtos.userDTO> ListarUsuarios();
        [OperationContract]
        Dominio.Dtos.userDTO BuscarUsuarioPorID(int IDUser);
    }
}
