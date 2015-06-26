using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Categoria_Habitacion
{
   [ServiceContract]
    public interface ICategoria_HabitacionService
    {

           [OperationContract]
        int InsertarCategoriaHabitacion(Dominio.Dtos.categoria_habitacionDTO dto);
           [OperationContract]
        bool ActualizarCategoriaHabitacion(Dominio.Dtos.categoria_habitacionDTO dto);
           [OperationContract]
        bool EliminarCategoriaHabitacion(int id_categoria_habitacion);
           [OperationContract]
        Dominio.Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorID(int id_categoria_habitacion);
           [OperationContract]
        Dominio.Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorNombre(string ParamentroNombreCategoriaHabitacion);
           [OperationContract]
        List<Dominio.Dtos.categoria_habitacionDTO> ListarTodosLas_CategoriaHabitacion();

    }
}
