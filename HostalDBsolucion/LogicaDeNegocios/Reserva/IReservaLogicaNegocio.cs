using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Reserva
{
    public interface IReservaLogicaNegocio
    {
        int InsertarReserva(Dominio.Dtos.reservaDTO dto);
        bool ActualizarReserva(Dominio.Dtos.reservaDTO dto);
        bool EliminarReserva(int idHabitacion);
        Dominio.Dtos.reservaDTO BuscarReservaPorID(int idReserva);
        List<Dominio.Dtos.reservaDTO> ListarTodasLasReservas();
        List<Dominio.Dtos.reservaDTO> ListarReservasPorCliente(int idCliente);

    }
}
