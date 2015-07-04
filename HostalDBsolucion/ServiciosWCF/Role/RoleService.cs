using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Role.IRoleService 
    {
        LogicaDeNegocios.Role.IRoleLogicaNegocio RoleLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();
        
        public int InsertarRol(Dominio.Dtos.roleDTO dto)
        {
            try
            {
                return RoleLogicaNegocio.InsertarRol(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarRol(Dominio.Dtos.roleDTO dto)
        {
            try
            {
                return RoleLogicaNegocio.ActualizarRol(dto);
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
                return RoleLogicaNegocio.EliminarRol(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.roleDTO> BuscarRolPorNombre(string ParametroNombreRol)
        {
            try
            {
                return RoleLogicaNegocio.BuscarRolPorNombre(ParametroNombreRol);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.roleDTO> ListarTodosLosRoles()
        {
            try
            {
                return RoleLogicaNegocio.ListarTodosLosRoles();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.roleDTO BuscarRolPorID(int ParametroIDrol)
        {
            try
            {
                return RoleLogicaNegocio.BuscarRolPorID(ParametroIDrol);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}