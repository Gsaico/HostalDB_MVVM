using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Habitacion.IHabitacionLogicaNegocio  
    {
        Dominio.Querys.Habitacion.IHabitacionQuery  habitacionQuerys = new Dominio.Querys.Querys();


        public int InsertarHabitacion(Dominio.Dtos.habitacionDTO dto)
        {
            try
            {
                return habitacionQuerys.InsertarHabitacion (dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarHabitacion(Dominio.Dtos.habitacionDTO dto)
        {
            try
            {
                return habitacionQuerys.ActualizarHabitacion (dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarHabitacion(int idHabitacion)
        {
            try
            {
                return habitacionQuerys.EliminarHabitacion(idHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.habitacionDTO BuscarHabitacionPorID(int idHabitacion)
        {
            try
            {
                return habitacionQuerys.BuscarHabitacionPorID(idHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarTodasLasHabitaciones()
        {
            try
            {
                return habitacionQuerys.ListarTodasLasHabitaciones ();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarHabitacionesDisponibles()
        {
            try
            {
                return habitacionQuerys.ListarHabitacionesDisponibles ();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarHabitacionesOcupadas()
        {
            try
            {
                return habitacionQuerys.ListarHabitacionesOcupadas();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarHabitacionesPorCategoria(int idCategoria)
        {
            try
            {
                return habitacionQuerys.ListarHabitacionesPorCategoria (idCategoria);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.habitacionDTO> ListarHabitacionesPorTipoDehabitacion(int idTipohabitacion)
        {
            try
            {
                return habitacionQuerys.ListarHabitacionesPorTipoDehabitacion (idTipohabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
