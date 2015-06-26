using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Tipo_Comprobante
{
    public interface ITipoComprobanteLogicaNegocio
    {
        int InsertarTipoComprobante(Dominio.Dtos.TipoComprobanteDTO dto);
        bool ActualizarTipoComprobante(Dominio.Dtos.TipoComprobanteDTO dto);
        bool EliminarTipoComprobante(int IDTipoComprobante);
        Dominio.Dtos.TipoComprobanteDTO BuscarTipoComprobantePorNombre(string NombreComprobante);
        Dominio.Dtos.TipoComprobanteDTO BuscarTipoComprobantePorID(int IDTipoComprobante);
        List<Dominio.Dtos.TipoComprobanteDTO> ListarTodosLosTiposDeComprobante();
    }
}
