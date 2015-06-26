using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Categoria_Habitacion.ICategoria_HabitacionLogicaNegocio  
    {
        Dominio.Querys.Categoria_Habitacion.ICategoria_HabitacionQuery  Categoria_HabitacionQuerys = new Dominio.Querys.Querys();


        public int InsertarCategoriaHabitacion(Dominio.Dtos.categoria_habitacionDTO dto)
        {
            try
            {
                return Categoria_HabitacionQuerys.InsertarCategoriaHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarCategoriaHabitacion(Dominio.Dtos.categoria_habitacionDTO dto)
        {
            try
            {
                return Categoria_HabitacionQuerys.ActualizarCategoriaHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarCategoriaHabitacion(int id_categoria_habitacion)
        {
            try
            {
                return Categoria_HabitacionQuerys.EliminarCategoriaHabitacion(id_categoria_habitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorID(int id_categoria_habitacion)
        {
            try
            {
                return Categoria_HabitacionQuerys.BuscarCategoriaHabitacionPorID(id_categoria_habitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorNombre(string ParamentroNombreCategoriaHabitacion)
        {
            try
            {
                return Categoria_HabitacionQuerys.BuscarCategoriaHabitacionPorNombre(ParamentroNombreCategoriaHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.categoria_habitacionDTO> ListarTodosLas_CategoriaHabitacion()
        {
            try
            {
                return Categoria_HabitacionQuerys.ListarTodosLas_CategoriaHabitacion();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
