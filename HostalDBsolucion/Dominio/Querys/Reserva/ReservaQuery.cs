using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Reserva.IReservaQuery
    {



        public int InsertarReserva(Dtos.reservaDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.reserva.Add(entity);
                    modelo.SaveChanges();
                    return entity.reserva_id;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarReserva(Dtos.reservaDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.reserva.Where(q => q.reserva_id == dto.reserva_id ).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.reservaAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarReserva(int idHabitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.reserva x = modelo.reserva.Where(q => q.reserva_id == idHabitacion).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.reserva.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.reservaDTO BuscarReservaPorID(int idReserva)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.reserva.Where(q => q.reserva_id == idReserva).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.reservaAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.reservaDTO> ListarTodasLasReservas()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.reserva.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.reservaAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.reservaDTO> ListarReservasPorCliente(int idCliente)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.reserva.Where(q => q.cliente_id == idCliente).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.reservaAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
