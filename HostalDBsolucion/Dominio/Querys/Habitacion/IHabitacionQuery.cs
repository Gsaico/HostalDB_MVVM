using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;
using System.Collections;

namespace Dominio.Querys.Habitacion
{
   public interface IHabitacionQuery
    {
        int InsertarHabitacion(Dtos.habitacionDTO   dto);
        bool ActualizarHabitacion(Dtos.habitacionDTO dto);
        bool EliminarHabitacion(int idHabitacion);
        Dtos.habitacionDTO BuscarHabitacionPorID(int idHabitacion);
        List<Dtos.habitacionDTO> ListarTodasLasHabitaciones();
        List<ListarHabitacionesDisponiblesClass> ListarHabitacionesDisponibles();
        List<Dtos.habitacionDTO> ListarHabitacionesOcupadas();
        List<Dtos.habitacionDTO> ListarHabitacionesPorCategoria(int idCategoria);
        List<Dtos.habitacionDTO> ListarHabitacionesPorTipoDehabitacion(int idTipohabitacion);
    }
}
