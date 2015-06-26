using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Comprobante
{
    public interface IComprobanteLogicaNegocio
    {
        bool InsertarComprobante(Dominio.Dtos.comprobanteDTO dto);
        bool ActualizarComprobante(Dominio.Dtos.comprobanteDTO dto);
        bool EliminarComprobante(int id);
        Dominio.Dtos.comprobanteDTO BuscarComprobantePorID(int id);
        List<Dominio.Dtos.comprobanteDTO> ListarComprobantesPorIDCLIENTE(int idcliente);
        Dominio.Dtos.comprobanteDTO BuscarComprobantePorIDRESERVA(int idreserva);
        List<Dominio.Dtos.comprobanteDTO> ListarTodosLosComprobantes();
        List<Dominio.Dtos.comprobanteDTO> ListarComprobantesPorTIPOCOMPROBANTE(int idcomprobante);
    }
}
