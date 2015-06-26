using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Tipo_Comprobante
{
   [ServiceContract]
    public interface ITipoComprobanteService
    {
        [OperationContract]
        int InsertarTipoComprobante(Dominio.Dtos.TipoComprobanteDTO dto);
        [OperationContract]
        bool ActualizarTipoComprobante(Dominio.Dtos.TipoComprobanteDTO dto);
        [OperationContract]
        bool EliminarTipoComprobante(int IDTipoComprobante);
        [OperationContract]
        Dominio.Dtos.TipoComprobanteDTO BuscarTipoComprobantePorNombre(string NombreComprobante);
        [OperationContract]
        Dominio.Dtos.TipoComprobanteDTO BuscarTipoComprobantePorID(int IDTipoComprobante);
        [OperationContract]
        List<Dominio.Dtos.TipoComprobanteDTO> ListarTodosLosTiposDeComprobante();
    }
}
