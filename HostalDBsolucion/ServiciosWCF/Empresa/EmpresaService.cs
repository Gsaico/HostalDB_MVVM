using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Empresa.IEmpresaService  
    {
        LogicaDeNegocios.Empresa.IEmpresaLogicaNegocio empresaLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();

        
        public bool InsertarEmpresa(Dominio.Dtos.EmpresaDTO dto)
        {
            try
            {
                return empresaLogicaNegocio.InsertarEmpresa(dto);
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
                return empresaLogicaNegocio.ActualizarEmpresa(dto);
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
                return empresaLogicaNegocio.EliminarEmpresa(RUC);
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
                return empresaLogicaNegocio.BuscarEmpresasPorRazonSocial(parametroRazonSocial);
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
                return empresaLogicaNegocio.BuscarEmpresaPorRUC(RUC);
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
                return empresaLogicaNegocio.ListarTodasLasEmpresas();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}