using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Collections;

namespace LogicaDeNegocios.Habitacion
{
    public interface IHabitacionLogicaNegocio
    {
      
        int InsertarHabitacion(Dominio.Dtos.habitacionDTO dto);
        bool ActualizarHabitacion(Dominio.Dtos.habitacionDTO dto);
        bool EliminarHabitacion(int idHabitacion);
        Dominio.Dtos.habitacionDTO BuscarHabitacionPorID(int idHabitacion);
        List<Dominio.Dtos.habitacionDTO> ListarTodasLasHabitaciones();
        List<Dominio.Querys.ListarHabitacionesDisponiblesClass> ListarHabitacionesDisponibles();
        List<Dominio.Dtos.habitacionDTO> ListarHabitacionesOcupadas();
        List<Dominio.Dtos.habitacionDTO> ListarHabitacionesPorCategoria(int idCategoria);
        List<Dominio.Dtos.habitacionDTO> ListarHabitacionesPorTipoDehabitacion(int idTipohabitacion);

    }
}
