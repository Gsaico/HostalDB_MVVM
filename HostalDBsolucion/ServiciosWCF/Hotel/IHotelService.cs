using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Hotel
{
   [ServiceContract]
   public interface IHotelService
    {
        [OperationContract]
        int InsertarHotel(Dominio.Dtos.hotelDTO dto);
        [OperationContract]
        bool ActualizarHotel(Dominio.Dtos.hotelDTO dto);
        [OperationContract]
        bool EliminarHotel(int IDHotel);
        [OperationContract]
        Dominio.Dtos.hotelDTO BuscarHotelPorID(int IDHotel);
        [OperationContract]
        Dominio.Dtos.hotelDTO BuscarHotelPorNombre(string parametro);
        [OperationContract]
        List<Dominio.Dtos.hotelDTO> ListarTodosLosHoteles();
    }
}
