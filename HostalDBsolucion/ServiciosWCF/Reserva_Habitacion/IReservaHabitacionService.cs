using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Reserva_Habitacion
{
   [ServiceContract]
    public interface IReservaHabitacionService
    {
         [OperationContract]
        int InsertarReservaHabitacion(Dominio.Dtos.reserva_habitacionDTO dto);
         [OperationContract]
        bool ActualizarReservaHabitacion(Dominio.Dtos.reserva_habitacionDTO dto);
         [OperationContract]
        bool EliminarReservaHabitacion(int idReservaHabitacion);
         [OperationContract]
        List<Dominio.Dtos.reserva_habitacionDTO> BuscarReservaHabitacionPorID(int idReservaHabitacion);
         [OperationContract]
        List<Dominio.Dtos.reserva_habitacionDTO> ListarReservaHabitacionPorReservaID(int Reserva_id);
         [OperationContract]
        List<Dominio.Dtos.reserva_habitacionDTO> ListarReservasHabitacionPorHabitacionID(int Habitacion_id);
    }
}
