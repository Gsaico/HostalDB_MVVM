using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Tipo_Habitacion
{
   public interface ITipo_HabitacionQuery
    {    

        int InsertarTipoHabitacion(Dtos.tipo_habitacionDTO   dto);
        bool ActualizarTipoHabitacion(Dtos.tipo_habitacionDTO dto);
        bool EliminarTipoHabitacion(int id_tipo_habitacion);
        Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorID(int id_tipo_habitacion);
        Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorNombre(string ParamentroNombreHabitacion);
        List<Dtos.tipo_habitacionDTO> ListarTodosLos_TiposHabitacion();
       
    }
}
