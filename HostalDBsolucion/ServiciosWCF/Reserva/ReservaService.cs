using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Reserva.IReservaService  
    {
        LogicaDeNegocios.Reserva.IReservaLogicaNegocio reservaLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();


        public int InsertarReserva(Dominio.Dtos.reservaDTO dto)
        {
            try
            {
                return reservaLogicaNegocio.InsertarReserva(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarReserva(Dominio.Dtos.reservaDTO dto)
        {
            try
            {
                return reservaLogicaNegocio.ActualizarReserva(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarReserva(int idHabitacion)
        {
            try
            {
                return reservaLogicaNegocio.EliminarReserva(idHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.reservaDTO BuscarReservaPorID(int idReserva)
        {
            try
            {
                return reservaLogicaNegocio.BuscarReservaPorID(idReserva);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.reservaDTO> ListarTodasLasReservas()
        {
            try
            {
                return reservaLogicaNegocio.ListarTodasLasReservas();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.reservaDTO> ListarReservasPorCliente(int idCliente)
        {
            try
            {
                return reservaLogicaNegocio.ListarReservasPorCliente(idCliente);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}