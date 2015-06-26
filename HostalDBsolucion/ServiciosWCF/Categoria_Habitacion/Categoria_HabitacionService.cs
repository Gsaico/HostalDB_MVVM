using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Categoria_Habitacion.ICategoria_HabitacionService 
    {
        LogicaDeNegocios.Categoria_Habitacion.ICategoria_HabitacionLogicaNegocio CategoriaHabitacionLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();




        public int InsertarCategoriaHabitacion(Dominio.Dtos.categoria_habitacionDTO dto)
        {
            try
            {
                return CategoriaHabitacionLogicaNegocio.InsertarCategoriaHabitacion(dto);
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
                return CategoriaHabitacionLogicaNegocio.ActualizarCategoriaHabitacion(dto);
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
                return CategoriaHabitacionLogicaNegocio.EliminarCategoriaHabitacion(id_categoria_habitacion);
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
                return CategoriaHabitacionLogicaNegocio.BuscarCategoriaHabitacionPorID(id_categoria_habitacion);
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
                return CategoriaHabitacionLogicaNegocio.BuscarCategoriaHabitacionPorNombre(ParamentroNombreCategoriaHabitacion);
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
                return CategoriaHabitacionLogicaNegocio.ListarTodosLas_CategoriaHabitacion();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}