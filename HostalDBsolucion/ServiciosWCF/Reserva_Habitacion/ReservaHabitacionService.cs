using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Reserva_Habitacion.IReservaHabitacionService  
    {
        LogicaDeNegocios.Reserva_Habitacion.IReserva_HabitacionLogicaNegocio  reservahabitacionLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();




        public int InsertarReservaHabitacion(Dominio.Dtos.reserva_habitacionDTO dto)
        {
            try
            {
                return reservahabitacionLogicaNegocio.InsertarReservaHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarReservaHabitacion(Dominio.Dtos.reserva_habitacionDTO dto)
        {
            try
            {
                return reservahabitacionLogicaNegocio.ActualizarReservaHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarReservaHabitacion(int idReservaHabitacion)
        {
            try
            {
                return reservahabitacionLogicaNegocio.EliminarReservaHabitacion(idReservaHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.reserva_habitacionDTO> BuscarReservaHabitacionPorID(int idReservaHabitacion)
        {
            try
            {
                return reservahabitacionLogicaNegocio.BuscarReservaHabitacionPorID(idReservaHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.reserva_habitacionDTO> ListarReservaHabitacionPorReservaID(int Reserva_id)
        {
            try
            {
                return reservahabitacionLogicaNegocio.ListarReservaHabitacionPorReservaID(Reserva_id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.reserva_habitacionDTO> ListarReservasHabitacionPorHabitacionID(int Habitacion_id)
        {
            try
            {
                return reservahabitacionLogicaNegocio.ListarReservasHabitacionPorHabitacionID(Habitacion_id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}