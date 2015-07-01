using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Habitacion
{
   [ServiceContract]
   public interface IHabitacionService
    {
        

       [OperationContract]
        int InsertarHabitacion(Dominio.Dtos.habitacionDTO dto);
        [OperationContract]
        bool ActualizarHabitacion(Dominio.Dtos.habitacionDTO dto);
        [OperationContract]
        bool EliminarHabitacion(int idHabitacion);
        [OperationContract]
        Dominio.Dtos.habitacionDTO BuscarHabitacionPorID(int idHabitacion);
        [OperationContract]
        List<Dominio.Dtos.habitacionDTO> ListarTodasLasHabitaciones();
        [OperationContract]
        List<Dominio.Querys.ListarHabitacionesDisponiblesClass> ListarHabitacionesDisponibles();
        [OperationContract]
        List<Dominio.Dtos.habitacionDTO> ListarHabitacionesOcupadas();
        [OperationContract]
        List<Dominio.Dtos.habitacionDTO> ListarHabitacionesPorCategoria(int idCategoria);
        [OperationContract]
        List<Dominio.Dtos.habitacionDTO> ListarHabitacionesPorTipoDehabitacion(int idTipohabitacion);

    }
}
