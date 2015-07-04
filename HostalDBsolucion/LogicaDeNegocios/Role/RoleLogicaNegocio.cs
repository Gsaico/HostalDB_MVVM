using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Role.IRoleLogicaNegocio 
    {
        Dominio.Querys.Role.IRoleQuery   roleQuerys = new Dominio.Querys.Querys();


        public int InsertarRol(Dominio.Dtos.roleDTO dto)
        {
            try
            {
                return roleQuerys.InsertarRol(dto);
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
                return roleQuerys.ActualizarRol(dto);
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
                return roleQuerys.EliminarRol(id);
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
                return roleQuerys.BuscarRolPorNombre(ParametroNombreRol);
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
                return roleQuerys.ListarTodosLosRoles();
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
                return roleQuerys.BuscarRolPorID(ParametroIDrol);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
