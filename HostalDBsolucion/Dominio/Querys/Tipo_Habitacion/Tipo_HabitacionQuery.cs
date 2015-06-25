using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Tipo_Habitacion.ITipo_HabitacionQuery
    {


        public int InsertarTipoHabitacion(Dtos.tipo_habitacionDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.tipo_habitacion.Add(entity);
                    modelo.SaveChanges();
                    return entity.tipo_habitacion_id;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarTipoHabitacion(Dtos.tipo_habitacionDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.tipo_habitacion.Where(q => q.tipo_habitacion_id == dto.tipo_habitacion_id).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.tipo_habitacionAssembler .Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarTipoHabitacion(int id_tipo_habitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.tipo_habitacion x = modelo.tipo_habitacion.Where(q => q.tipo_habitacion_id == id_tipo_habitacion).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.tipo_habitacion.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorID(int id_tipo_habitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.tipo_habitacion.Where(q => q.tipo_habitacion_id == id_tipo_habitacion).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.tipo_habitacionAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorNombre(string ParamentroNombreHabitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.tipo_habitacion.Where(q => q.nombre.Contains(ParamentroNombreHabitacion)).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.tipo_habitacionAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.tipo_habitacionDTO> ListarTodosLos_TiposHabitacion()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.tipo_habitacion.Select (q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.tipo_habitacionAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
