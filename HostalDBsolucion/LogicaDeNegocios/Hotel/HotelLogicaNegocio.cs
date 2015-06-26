using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Hotel.IHotelLogicaNegocio 
    {
        Dominio.Querys.Hotel.IHotelQuery   hotelQuerys = new Dominio.Querys.Querys();


        public int InsertarHotel(Dominio.Dtos.hotelDTO dto)
        {
            try
            {
                return hotelQuerys.InsertarHotel(dto);
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
                return hotelQuerys.ActualizarHotel(dto);
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
                return hotelQuerys.EliminarHotel(IDHotel);
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
                return hotelQuerys.BuscarHotelPorID(IDHotel);
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
                return hotelQuerys.BuscarHotelPorNombre(parametro);
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
                return hotelQuerys.ListarTodosLosHoteles();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
