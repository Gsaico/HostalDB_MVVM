using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Tipo_Habitacion.ITipoHabitacionService 
    {
        LogicaDeNegocios.Tipo_Habitacion.ITipoHabitacionLogicaNegocio TipoHabitacionLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();




        public int InsertarTipoHabitacion(Dominio.Dtos.tipo_habitacionDTO dto)
        {
            try
            {
                return TipoHabitacionLogicaNegocio.InsertarTipoHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarTipoHabitacion(Dominio.Dtos.tipo_habitacionDTO dto)
        {
            try
            {
                return TipoHabitacionLogicaNegocio.ActualizarTipoHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarTipoHabitacion(int id_tipo_habitacion)
        {
            try
            {
                return TipoHabitacionLogicaNegocio.EliminarTipoHabitacion(id_tipo_habitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorID(int id_tipo_habitacion)
        {
            try
            {
                return TipoHabitacionLogicaNegocio.BuscarTipoHabitacionPorID(id_tipo_habitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorNombre(string ParamentroNombreHabitacion)
        {
            try
            {
                return TipoHabitacionLogicaNegocio.BuscarTipoHabitacionPorNombre(ParamentroNombreHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.tipo_habitacionDTO> ListarTodosLos_TiposHabitacion()
        {
            try
            {
                return TipoHabitacionLogicaNegocio.ListarTodosLos_TiposHabitacion();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}