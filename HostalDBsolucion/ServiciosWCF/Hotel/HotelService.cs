using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Hotel.IHotelService 
    {
        LogicaDeNegocios.Hotel.IHotelLogicaNegocio hotelLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();




        public int InsertarHotel(Dominio.Dtos.hotelDTO dto)
        {
            try
            {
                return hotelLogicaNegocio.InsertarHotel(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarHotel(Dominio.Dtos.hotelDTO dto)
        {
            try
            {
                return hotelLogicaNegocio.ActualizarHotel(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarHotel(int IDHotel)
        {
            try
            {
                return hotelLogicaNegocio.EliminarHotel(IDHotel);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.hotelDTO BuscarHotelPorID(int IDHotel)
        {
            try
            {
                return hotelLogicaNegocio.BuscarHotelPorID(IDHotel);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.hotelDTO BuscarHotelPorNombre(string parametro)
        {
            try
            {
                return hotelLogicaNegocio.BuscarHotelPorNombre(parametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.hotelDTO> ListarTodosLosHoteles()
        {
            try
            {
                return hotelLogicaNegocio.ListarTodosLosHoteles();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}