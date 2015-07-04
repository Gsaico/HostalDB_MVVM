using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : User_Role.IUser_RoleService  
    {
        LogicaDeNegocios.User_Role.IUser_RoleLogicaNegocio user_roleLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();


        public int InsertarUserRole(Dominio.Dtos.user_roleDTO dto)
        {
            try
            {
                return user_roleLogicaNegocio.InsertarUserRole(dto);
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
                return user_roleLogicaNegocio.ActualizarUserRole(dto);
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
                return user_roleLogicaNegocio.EliminarUserRole(IDUSERROLparametro);
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
                return user_roleLogicaNegocio.ListarUserRolePorIDUSER(IDUSERparametro);
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
                return user_roleLogicaNegocio.ListarUserRolePorIDROL(IDROLparametro);
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
                return user_roleLogicaNegocio.BuscarUserRolePorIDUSER(IDUSERparametro);
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
                return user_roleLogicaNegocio.BuscarUserRolePorIDROL(IDROLparametro);
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
                return user_roleLogicaNegocio.ListarRolesDelUsuario(IDUSERparametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}