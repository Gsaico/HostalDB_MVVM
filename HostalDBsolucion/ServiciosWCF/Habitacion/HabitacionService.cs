using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Habitacion.IHabitacionService  
    {
        LogicaDeNegocios.Habitacion.IHabitacionLogicaNegocio HabitacionLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();



        public int InsertarHabitacion(Dominio.Dtos.habitacionDTO dto)
        {
            try
            {
                return HabitacionLogicaNegocio.InsertarHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarHabitacion(Dominio.Dtos.habitacionDTO dto)
        {
            try
            {
                return HabitacionLogicaNegocio.ActualizarHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarHabitacion(int idHabitacion)
        {
            try
            {
                return HabitacionLogicaNegocio.EliminarHabitacion(idHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.habitacionDTO BuscarHabitacionPorID(int idHabitacion)
        {
            try
            {
                return HabitacionLogicaNegocio.BuscarHabitacionPorID(idHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarTodasLasHabitaciones()
        {
            try
            {
                return HabitacionLogicaNegocio.ListarTodasLasHabitaciones();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarHabitacionesDisponibles()
        {
            try
            {
                return HabitacionLogicaNegocio.ListarHabitacionesDisponibles();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarHabitacionesOcupadas()
        {
            try
            {
                return HabitacionLogicaNegocio.ListarHabitacionesOcupadas();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarHabitacionesPorCategoria(int idCategoria)
        {
            try
            {
                return HabitacionLogicaNegocio.ListarHabitacionesPorCategoria(idCategoria);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarHabitacionesPorTipoDehabitacion(int idTipohabitacion)
        {
            try
            {
                return HabitacionLogicaNegocio.ListarHabitacionesPorTipoDehabitacion(idTipohabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}