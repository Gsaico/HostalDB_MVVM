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
    public partial class Querys : User_Role.IUser_RoleQuery
    {

        public class ListarRolesDelUsuarioClass
        {

            public int IDuserrol { get; set; }
            public int IDuser { get; set; }
            public int IDrol { get; set; }
            public String strAuthority { get; set; }

        }

        public int InsertarUserRole(Dtos.user_roleDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.user_role .Add(entity);
                    modelo.SaveChanges();
                    return entity.id;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUserRole(Dtos.user_roleDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.user_role.Where(q => q.id  == dto.id).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.user_roleAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUserRole(int IDUSERROLparametro)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.user_role x = modelo.user_role.Where(q => q.id == IDUSERROLparametro).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.user_role.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.user_roleDTO> ListarUserRolePorIDUSER(int IDUSERparametro)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.user_role.Where(q => q.user_id == IDUSERparametro).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.user_roleAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.user_roleDTO> ListarUserRolePorIDROL(int IDROLparametro)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.user_role.Where(q => q.role_id  == IDROLparametro).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.user_roleAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.user_roleDTO BuscarUserRolePorIDUSER(int IDUSERparametro)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.user_role.Where(q => q.user_id == IDUSERparametro).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.user_roleAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public Dtos.user_roleDTO BuscarUserRolePorIDROL(int IDROLparametro)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.user_role.Where(q => q.role_id  == IDROLparametro).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.user_roleAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<ListarRolesDelUsuarioClass> ListarRolesDelUsuario(int IDUSERparametro)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {

                    var query = from ur in modelo.user_role 
                                join r in modelo.role  on ur.role_id equals r.role_id
                                where ur.user_id == IDUSERparametro
                                select new ListarRolesDelUsuarioClass()
                                {
                                    
            IDuserrol = ur.id, 
            IDuser =ur.user_id, 
            IDrol = r.role_id, 
            strAuthority = r.authority 
                                   
                                };

                    return query.ToList();

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
