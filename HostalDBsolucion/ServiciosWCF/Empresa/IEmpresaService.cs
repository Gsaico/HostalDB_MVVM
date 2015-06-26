using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Empresa
{
   [ServiceContract]
    public interface IEmpresaService
    {
        [OperationContract]
        bool InsertarEmpresa(Dominio.Dtos.EmpresaDTO dto);
        [OperationContract]
        bool ActualizarEmpresa(Dominio.Dtos.EmpresaDTO dto);
        [OperationContract]
        bool EliminarEmpresa(string RUC);
        [OperationContract]
        List<Dominio.Dtos.EmpresaDTO> BuscarEmpresasPorRazonSocial(string parametroRazonSocial);
        [OperationContract]
        Dominio.Dtos.EmpresaDTO BuscarEmpresaPorRUC(string RUC);
        [OperationContract]
        List<Dominio.Dtos.EmpresaDTO> ListarTodasLasEmpresas();
    }
}
