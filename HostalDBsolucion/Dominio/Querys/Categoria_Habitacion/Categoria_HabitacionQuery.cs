using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Categoria_Habitacion.ICategoria_HabitacionQuery
    {


        public int InsertarCategoriaHabitacion(Dtos.categoria_habitacionDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.categoria_habitacion .Add(entity);
                    modelo.SaveChanges();
                    return entity.categoria_id ;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarCategoriaHabitacion(Dtos.categoria_habitacionDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.categoria_habitacion.Where(q => q.categoria_id == dto.categoria_id).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.categoria_habitacionAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarCategoriaHabitacion(int id_categoria_habitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.categoria_habitacion x = modelo.categoria_habitacion.Where(q => q.categoria_id == id_categoria_habitacion).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.categoria_habitacion.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorID(int id_categoria_habitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.categoria_habitacion.Where(q => q.categoria_id == id_categoria_habitacion).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.categoria_habitacionAssembler .ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public Dtos.categoria_habitacionDTO BuscarCategoriaHabitacionPorNombre(string ParamentroNombreCategoriaHabitacion)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.categoria_habitacion.Where(q => q.nombre.Contains(ParamentroNombreCategoriaHabitacion)).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.categoria_habitacionAssembler .ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.categoria_habitacionDTO> ListarTodosLas_CategoriaHabitacion()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.categoria_habitacion.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.categoria_habitacionAssembler .ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
