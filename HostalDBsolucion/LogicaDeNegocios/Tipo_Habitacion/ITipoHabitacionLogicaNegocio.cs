using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Tipo_Habitacion
{
    public interface ITipoHabitacionLogicaNegocio
    {
        int InsertarTipoHabitacion(Dominio.Dtos.tipo_habitacionDTO dto);
        bool ActualizarTipoHabitacion(Dominio.Dtos.tipo_habitacionDTO dto);
        bool EliminarTipoHabitacion(int id_tipo_habitacion);
        Dominio.Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorID(int id_tipo_habitacion);
        Dominio.Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorNombre(string ParamentroNombreHabitacion);
        List<Dominio.Dtos.tipo_habitacionDTO> ListarTodosLos_TiposHabitacion();
    }
}
