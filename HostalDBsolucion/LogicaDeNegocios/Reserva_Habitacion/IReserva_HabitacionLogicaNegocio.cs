using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Reserva_Habitacion
{
    public interface IReserva_HabitacionLogicaNegocio
    {
        int InsertarReservaHabitacion(Dominio.Dtos.reserva_habitacionDTO dto);
        bool ActualizarReservaHabitacion(Dominio.Dtos.reserva_habitacionDTO dto);
        bool EliminarReservaHabitacion(int idReservaHabitacion);
        List<Dominio.Dtos.reserva_habitacionDTO> BuscarReservaHabitacionPorID(int idReservaHabitacion);
        List<Dominio.Dtos.reserva_habitacionDTO> ListarReservaHabitacionPorReservaID(int Reserva_id);
        List<Dominio.Dtos.reserva_habitacionDTO> ListarReservasHabitacionPorHabitacionID(int Habitacion_id);
    }
}
