using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Reserva.IReservaLogicaNegocio  
    {
        Dominio.Querys.Reserva.IReservaQuery  reservaQuerys = new Dominio.Querys.Querys();

        public int InsertarReserva(Dominio.Dtos.reservaDTO dto)
        {
            try
            {
                return reservaQuerys.InsertarReserva(dto);
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
                return reservaQuerys.ActualizarReserva(dto);
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
                return reservaQuerys.EliminarReserva(idHabitacion);
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
                return reservaQuerys.BuscarReservaPorID(idReserva);
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
                return reservaQuerys.ListarTodasLasReservas();
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
                return reservaQuerys.ListarReservasPorCliente(idCliente);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
