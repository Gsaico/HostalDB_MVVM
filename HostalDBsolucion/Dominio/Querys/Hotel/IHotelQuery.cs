using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Hotel
{
   public interface IHotelQuery
    {
        int InsertarHotel(Dtos.hotelDTO   dto);
        bool ActualizarHotel(Dtos.hotelDTO dto);
        bool EliminarHotel(int IDHotel);
        Dtos.hotelDTO BuscarHotelPorID(int IDHotel);
        Dtos.hotelDTO BuscarHotelPorNombre(string parametro);
        List<Dtos.hotelDTO> ListarTodosLosHoteles();

        
    }
}
