using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Habitacion.IHabitacionQuery 
    {
        public int InsertarHabitacion(Dtos.habitacionDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.habitacion.Add(entity);
                    modelo.SaveChanges();
                    return entity.habitacion_id ;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarHabitacion(Dtos.habitacionDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.habitacion.Where(q => q.habitacion_id == dto.habitacion_id).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.habitacionAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
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
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.habitacion x = modelo.habitacion.Where(q => q.habitacion_id == idHabitacion).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.habitacion.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.habitacionDTO BuscarHabitacionPorID(int idHabitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.habitacion.Where(q => q.habitacion_id == idHabitacion).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.habitacionAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.habitacionDTO> ListarTodasLasHabitaciones()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.habitacion.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.habitacionAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.habitacionDTO> ListarHabitacionesDisponibles()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.habitacion.Where(q => q.ocupada == 0).ToList(); //0 = indica  habitacion Disponible

                    if (entity == null) return null;
                    return Dominio.Convertidores.habitacionAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.habitacionDTO> ListarHabitacionesOcupadas()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.habitacion.Where(q => q.ocupada == 1).ToList(); //1 = indica  habitacion Ocupada

                    if (entity == null) return null;
                    return Dominio.Convertidores.habitacionAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.habitacionDTO> ListarHabitacionesPorCategoria(int idCategoria)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.habitacion.Where(q => q.categoria_id == idCategoria).ToList(); 

                    if (entity == null) return null;
                    return Dominio.Convertidores.habitacionAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.habitacionDTO> ListarHabitacionesPorTipoDehabitacion(int idTipohabitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.habitacion.Where(q => q.tipo_habitacion_id == idTipohabitacion).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.habitacionAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
