using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Comprobante
{
   [ServiceContract]
    public interface IComprobanteService
    {

         [OperationContract]
        bool InsertarComprobante(Dominio.Dtos.comprobanteDTO dto);
         [OperationContract]
        bool ActualizarComprobante(Dominio.Dtos.comprobanteDTO dto);
         [OperationContract]
        bool EliminarComprobante(int id);
         [OperationContract]
        Dominio.Dtos.comprobanteDTO BuscarComprobantePorID(int id);
         [OperationContract]
        List<Dominio.Dtos.comprobanteDTO> ListarComprobantesPorIDCLIENTE(int idcliente);
         [OperationContract]
        Dominio.Dtos.comprobanteDTO BuscarComprobantePorIDRESERVA(int idreserva);
         [OperationContract]
        List<Dominio.Dtos.comprobanteDTO> ListarTodosLosComprobantes();
         [OperationContract]
        List<Dominio.Dtos.comprobanteDTO> ListarComprobantesPorTIPOCOMPROBANTE(int idcomprobante);
    }
}
