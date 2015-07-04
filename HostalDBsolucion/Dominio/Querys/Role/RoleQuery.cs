using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Role.IRoleQuery
    {


        public int InsertarRol(Dtos.roleDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.role.Add(entity);
                    modelo.SaveChanges();
                    return entity.role_id;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarRol(Dtos.roleDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.role.Where(q => q.role_id == dto.role_id).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.roleAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarRol(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.role  x = modelo.role.Where(q => q.role_id == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.role.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.roleDTO> BuscarRolPorNombre(string ParametroNombreRol)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.role.Where(q => q.authority.Contains(ParametroNombreRol)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.roleAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.roleDTO> ListarTodosLosRoles()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.role.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.roleAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.roleDTO BuscarRolPorID(int ParametroIDrol)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.role.Where(q => q.role_id == ParametroIDrol).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.roleAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
