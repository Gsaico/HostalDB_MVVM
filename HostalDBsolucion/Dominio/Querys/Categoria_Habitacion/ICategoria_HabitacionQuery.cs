using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Categoria_Habitacion
{
   public interface ICategoria_HabitacionQuery
    {    
        int InsertarCategoriaHabitacion(Dtos.categoria_habitacionDTO    dto);
        bool ActualizarCategoriaHabitacion(Dtos.categoria_habitacionDTO dto);
        bool EliminarCategoriaHabitacion(int id_categoria_habitacion);
        Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorID(int id_categoria_habitacion);
        Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorNombre(string ParamentroNombreCategoriaHabitacion);
        List<Dtos.categoria_habitacionDTO> ListarTodosLas_CategoriaHabitacion();
       
    }
}
