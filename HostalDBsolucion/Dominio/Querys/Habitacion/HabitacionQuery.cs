using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;
using Dominio.Querys.Habitacion;
using System.Collections;

namespace Dominio.Querys
{
    public partial class Querys : Habitacion.IHabitacionQuery
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
                    return entity.habitacion_id;
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

        public List<ListarHabitacionesDisponiblesClass> ListarHabitacionesDisponibles()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {

                    var query = from h in modelo.habitacion
                                join c in modelo.categoria_habitacion on h.categoria_id equals c.categoria_id
                                join t in modelo.tipo_habitacion on h.tipo_habitacion_id equals t.tipo_habitacion_id
                                where h.ocupada == 0
                                select new ListarHabitacionesDisponiblesClass()
                                {

                                    IDHabitacion = h.habitacion_id,
                                    IDnombrecategoria = c.categoria_id,
                                    Nombrecategoria = c.nombre,
                                    IDtipohabitacion = t.tipo_habitacion_id,
                                    TipoHabitacion = t.nombre
                                };

                    return query.ToList();

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
    public class ListarHabitacionesDisponiblesClass
    {

        public int IDHabitacion { get; set; }
        public int IDnombrecategoria { get; set; }
        public int IDtipohabitacion { get; set; }
        public String Nombrecategoria { get; set; }
        public String TipoHabitacion { get; set; }
    }
}
