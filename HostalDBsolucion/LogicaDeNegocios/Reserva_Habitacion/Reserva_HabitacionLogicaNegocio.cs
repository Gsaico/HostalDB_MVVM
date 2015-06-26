using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Reserva_Habitacion.IReserva_HabitacionLogicaNegocio 
    {
        Dominio.Querys.Reserva_Habitacion.IReserva_HabitacionQuery   ReservaHabitacionQuerys = new Dominio.Querys.Querys();


        public int InsertarReservaHabitacion(Dominio.Dtos.reserva_habitacionDTO dto)
        {
            try
            {
                return ReservaHabitacionQuerys.InsertarReservaHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarReservaHabitacion(Dominio.Dtos.reserva_habitacionDTO dto)
        {
            try
            {
                return ReservaHabitacionQuerys.ActualizarReservaHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarReservaHabitacion(int idReservaHabitacion)
        {
            try
            {
                return ReservaHabitacionQuerys.EliminarReservaHabitacion(idReservaHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.reserva_habitacionDTO> BuscarReservaHabitacionPorID(int idReservaHabitacion)
        {
            try
            {
                return ReservaHabitacionQuerys.BuscarReservaHabitacionPorID(idReservaHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.reserva_habitacionDTO> ListarReservaHabitacionPorReservaID(int Reserva_id)
        {
            try
            {
                return ReservaHabitacionQuerys.ListarReservaHabitacionPorReservaID(Reserva_id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.reserva_habitacionDTO> ListarReservasHabitacionPorHabitacionID(int Habitacion_id)
        {
            try
            {
                return ReservaHabitacionQuerys.ListarReservasHabitacionPorHabitacionID(Habitacion_id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
