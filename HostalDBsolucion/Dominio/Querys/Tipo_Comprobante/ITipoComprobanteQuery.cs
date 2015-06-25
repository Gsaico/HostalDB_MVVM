using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Tipo_Comprobante
{
   public interface ITipoComprobanteQuery
    {
        int InsertarTipoComprobante(Dtos.TipoComprobanteDTO   dto);
        bool ActualizarTipoComprobante(Dtos.TipoComprobanteDTO dto);
        bool EliminarTipoComprobante(int IDTipoComprobante);
        Dtos.TipoComprobanteDTO BuscarTipoComprobantePorNombre(string NombreComprobante);
        Dtos.TipoComprobanteDTO BuscarTipoComprobantePorID(int IDTipoComprobante);
        List<Dtos.TipoComprobanteDTO> ListarTodosLosTiposDeComprobante();
    }
}
