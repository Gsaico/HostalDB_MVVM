using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Empresa
{
    public interface IEmpresaLogicaNegocio
    {
        bool InsertarEmpresa(Dominio.Dtos.EmpresaDTO dto);
        bool ActualizarEmpresa(Dominio.Dtos.EmpresaDTO dto);
        bool EliminarEmpresa(string RUC);
        List<Dominio.Dtos.EmpresaDTO> BuscarEmpresasPorRazonSocial(string parametroRazonSocial);
        Dominio.Dtos.EmpresaDTO BuscarEmpresaPorRUC(string RUC);
        List<Dominio.Dtos.EmpresaDTO> ListarTodasLasEmpresas();
              
    }
}
