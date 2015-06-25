using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Empresa
{
   public interface IEmpresaQuery
    {
        bool InsertarEmpresa(Dtos.EmpresaDTO   dto);
        bool ActualizarEmpresa(Dtos.EmpresaDTO dto);
        bool EliminarEmpresa(string RUC);
        List<Dtos.EmpresaDTO> BuscarEmpresasPorRazonSocial(string parametroRazonSocial);
        Dtos.EmpresaDTO BuscarEmpresaPorRUC(string RUC);
        List<Dtos.EmpresaDTO> ListarTodasLasEmpresas();
              
    }
}
