using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: User.IUserQuery
    {
        public int InsertarUsuario(Dtos.userDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.user.Add(entity);
                    modelo.SaveChanges();
                    return entity.user_id;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsuario(Dtos.userDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.user.Where(q => q.user_id  == dto.user_id ).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.userAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsuario(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.user x = modelo.user.Where(q => q.user_id == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.user.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.userDTO> BuscarUsuario(string parametro)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.user.Where(q => q.nombre.Contains(parametro)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.userAssembler.ToDTOs (entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.userDTO> ListarUsuarios()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.user.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.userAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.userDTO BuscarUsuarioPorID(int IDUser)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.user.Where(q => q.user_id == IDUser).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.userAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
