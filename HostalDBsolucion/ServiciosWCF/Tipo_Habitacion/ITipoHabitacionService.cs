using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Tipo_Habitacion
{
   [ServiceContract]
    public interface ITipoHabitacionService
    {
        [OperationContract]
        int InsertarTipoHabitacion(Dominio.Dtos.tipo_habitacionDTO dto);
        [OperationContract]
        bool ActualizarTipoHabitacion(Dominio.Dtos.tipo_habitacionDTO dto);
        [OperationContract]
        bool EliminarTipoHabitacion(int id_tipo_habitacion);
        [OperationContract]
        Dominio.Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorID(int id_tipo_habitacion);
        [OperationContract]
        Dominio.Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorNombre(string ParamentroNombreHabitacion);
        [OperationContract]
        List<Dominio.Dtos.tipo_habitacionDTO> ListarTodosLos_TiposHabitacion();
    }
}
