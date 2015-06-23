using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : User.IUserLogicaNegocio 
    {
        Dominio.Querys.User.IUserQuery  userQuerys = new Dominio.Querys.Querys();
        public int InsertarUsuario(Dominio.Dtos.userDTO dto)
        {
            try
            {
                return userQuerys.InsertarUsuario(dto);
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
                return userQuerys.ActualizarUsuario (dto);
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
                return userQuerys.EliminarUsuario (id);
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
                return userQuerys.BuscarUsuario(parametro);
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
                return userQuerys.ListarUsuarios();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
