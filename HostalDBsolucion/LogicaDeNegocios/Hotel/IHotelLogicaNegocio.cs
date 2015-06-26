using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Hotel
{
    public interface IHotelLogicaNegocio
    {
        int InsertarHotel(Dominio.Dtos.hotelDTO dto);
        bool ActualizarHotel(Dominio.Dtos.hotelDTO dto);
        bool EliminarHotel(int IDHotel);
        Dominio.Dtos.hotelDTO BuscarHotelPorID(int IDHotel);
        Dominio.Dtos.hotelDTO BuscarHotelPorNombre(string parametro);
        List<Dominio.Dtos.hotelDTO> ListarTodosLosHoteles();

    }
}
