using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : User.IUserService 
    {
        LogicaDeNegocios.User.IUserLogicaNegocio UserLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();


        public int InsertarUsuario(Dominio.Dtos.userDTO dto)
        {
            try
            {
                return UserLogicaNegocio.InsertarUsuario (dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsuario(Dominio.Dtos.userDTO dto)
        {
            try
            {
                return UserLogicaNegocio.ActualizarUsuario (dto);
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
                return UserLogicaNegocio.EliminarUsuario (id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.userDTO> BuscarUsuario(string parametro)
        {
            try
            {
                return UserLogicaNegocio.BuscarUsuario(parametro);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dominio.Dtos.userDTO> ListarUsuarios()
        {
            try
            {
                return UserLogicaNegocio.ListarUsuarios ();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public Dominio.Dtos.userDTO BuscarUsuarioPorID(int IDUser)
        {
            try
            {
                return UserLogicaNegocio.BuscarUsuarioPorID(IDUser);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}