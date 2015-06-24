using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Reserva
{
    [ServiceContract]
    public interface IReservaService
    {


        [OperationContract]
        int InsertarReserva(Dominio.Dtos.reservaDTO dto);

        [OperationContract]
        bool ActualizarReserva(Dominio.Dtos.reservaDTO dto);

        [OperationContract]
        bool EliminarReserva(int idHabitacion);

        [OperationContract]
        Dominio.Dtos.reservaDTO BuscarReservaPorID(int idReserva);

        [OperationContract]
        List<Dominio.Dtos.reservaDTO> ListarTodasLasReservas();

        [OperationContract]
        List<Dominio.Dtos.reservaDTO> ListarReservasPorCliente(int idCliente);

    }
}
