using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Reserva_Habitacion.IReserva_HabitacionQuery
    {
       
        public int InsertarReservaHabitacion(Dtos.reserva_habitacionDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.reserva_habitacion.Add(entity);
                    modelo.SaveChanges();
                    return entity.id;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarReservaHabitacion(Dtos.reserva_habitacionDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.reserva_habitacion.Where(q => q.id == dto.id && q.habitacion_id == dto.habitacion_id).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.reserva_habitacionAssembler .Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
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
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.reserva_habitacion x = modelo.reserva_habitacion.Where(q => q.id == idReservaHabitacion).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.reserva_habitacion .Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.reserva_habitacionDTO> BuscarReservaHabitacionPorID(int idReservaHabitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.reserva_habitacion.Where(q => q.id == idReservaHabitacion).Select(q => q).ToList ();

                    if (entity == null) return null;
                    return Dominio.Convertidores.reserva_habitacionAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.reserva_habitacionDTO> ListarReservaHabitacionPorReservaID(int Reserva_id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.reserva_habitacion.Where(q => q.reserva_id == Reserva_id).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.reserva_habitacionAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.reserva_habitacionDTO> ListarReservasHabitacionPorHabitacionID(int Habitacion_id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.reserva_habitacion.Where(q => q.habitacion_id == Habitacion_id).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.reserva_habitacionAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
