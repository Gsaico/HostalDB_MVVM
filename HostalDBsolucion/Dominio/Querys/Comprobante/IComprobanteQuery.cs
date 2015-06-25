using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Comprobante
{
   public interface IComprobanteQuery
    {
        bool InsertarComprobante(Dtos.comprobanteDTO  dto);
        bool ActualizarComprobante(Dtos.comprobanteDTO dto);
        bool EliminarComprobante(int id);
        Dtos.comprobanteDTO BuscarComprobantePorID(int id);

        List<Dtos.comprobanteDTO> ListarComprobantesPorIDCLIENTE(int idcliente);
        Dtos.comprobanteDTO BuscarComprobantePorIDRESERVA(int idreserva);
        List<Dtos.comprobanteDTO> ListarTodosLosComprobantes();
        List<Dtos.comprobanteDTO> ListarComprobantesPorTIPOCOMPROBANTE(int idcomprobante);

    }
}
