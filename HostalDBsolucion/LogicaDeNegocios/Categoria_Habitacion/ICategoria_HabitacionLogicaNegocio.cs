using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Categoria_Habitacion
{
    public interface ICategoria_HabitacionLogicaNegocio
    {

        int InsertarCategoriaHabitacion(Dominio.Dtos.categoria_habitacionDTO dto);
        bool ActualizarCategoriaHabitacion(Dominio.Dtos.categoria_habitacionDTO dto);
        bool EliminarCategoriaHabitacion(int id_categoria_habitacion);
        Dominio.Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorID(int id_categoria_habitacion);
        Dominio.Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorNombre(string ParamentroNombreCategoriaHabitacion);
        List<Dominio.Dtos.categoria_habitacionDTO> ListarTodosLas_CategoriaHabitacion();
    }
}
