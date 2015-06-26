using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Empresa.IEmpresaLogicaNegocio  
    {

        Dominio.Querys.Empresa.IEmpresaQuery  empresaQuerys = new Dominio.Querys.Querys();
        public bool InsertarEmpresa(Dominio.Dtos.EmpresaDTO dto)
        {
            try
            {
                return empresaQuerys.InsertarEmpresa(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarEmpresa(Dominio.Dtos.EmpresaDTO dto)
        {
            try
            {
                return empresaQuerys.ActualizarEmpresa(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarEmpresa(string RUC)
        {
            try
            {
                return empresaQuerys.EliminarEmpresa(RUC);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.EmpresaDTO> BuscarEmpresasPorRazonSocial(string parametroRazonSocial)
        {
            try
            {
                return empresaQuerys.BuscarEmpresasPorRazonSocial(parametroRazonSocial);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.EmpresaDTO BuscarEmpresaPorRUC(string RUC)
        {
            try
            {
                return empresaQuerys.BuscarEmpresaPorRUC(RUC);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.EmpresaDTO> ListarTodasLasEmpresas()
        {
            try
            {
                return empresaQuerys.ListarTodasLasEmpresas();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
