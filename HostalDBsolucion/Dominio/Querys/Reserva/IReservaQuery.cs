using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Reserva
{
   public interface IReservaQuery
    {    

        int InsertarReserva(Dtos.reservaDTO dto);
        bool ActualizarReserva(Dtos.reservaDTO dto);
        bool EliminarReserva(int idHabitacion);
        Dtos.reservaDTO BuscarReservaPorID(int idReserva);
        List<Dtos.reservaDTO> ListarTodasLasReservas();
        List<Dtos.reservaDTO> ListarReservasPorCliente(int idCliente);
       
    }
}
