using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : User_Role.IUser_RoleLogicaNegocio  
    {
        Dominio.Querys.User_Role.IUser_RoleQuery  user_roleQuerys = new Dominio.Querys.Querys();




        public int InsertarUserRole(Dominio.Dtos.user_roleDTO dto)
        {
            try
            {
                return user_roleQuerys.InsertarUserRole(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUserRole(Dominio.Dtos.user_roleDTO dto)
        {
            try
            {
                return user_roleQuerys.ActualizarUserRole(dto);
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
                return user_roleQuerys.EliminarUserRole(IDUSERROLparametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.user_roleDTO> ListarUserRolePorIDUSER(int IDUSERparametro)
        {
            try
            {
                return user_roleQuerys.ListarUserRolePorIDUSER(IDUSERparametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.user_roleDTO> ListarUserRolePorIDROL(int IDROLparametro)
        {
            try
            {
                return user_roleQuerys.ListarUserRolePorIDROL(IDROLparametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.user_roleDTO BuscarUserRolePorIDUSER(int IDUSERparametro)
        {
            try
            {
                return user_roleQuerys.BuscarUserRolePorIDUSER(IDUSERparametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.user_roleDTO BuscarUserRolePorIDROL(int IDROLparametro)
        {
            try
            {
                return user_roleQuerys.BuscarUserRolePorIDROL(IDROLparametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Querys.Querys.ListarRolesDelUsuarioClass> ListarRolesDelUsuario(int IDUSERparametro)
        {
            try
            {
                return user_roleQuerys.ListarRolesDelUsuario(IDUSERparametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
