using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Reserva_Habitacion
{
   public interface IReserva_HabitacionQuery
    {    

        int InsertarReservaHabitacion(Dtos.reserva_habitacionDTO  dto);
        bool ActualizarReservaHabitacion(Dtos.reserva_habitacionDTO dto);
        bool EliminarReservaHabitacion(int idReservaHabitacion);
        List<Dtos.reserva_habitacionDTO> BuscarReservaHabitacionPorID(int idReservaHabitacion);
        List<Dtos.reserva_habitacionDTO> ListarReservaHabitacionPorReservaID(int Reserva_id);
        List<Dtos.reserva_habitacionDTO> ListarReservasHabitacionPorHabitacionID(int Habitacion_id);
       
    }
}
