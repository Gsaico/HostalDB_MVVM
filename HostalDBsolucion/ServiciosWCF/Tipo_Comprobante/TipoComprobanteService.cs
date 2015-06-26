using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Tipo_Comprobante.ITipoComprobanteService  
    {
        LogicaDeNegocios.Tipo_Comprobante.ITipoComprobanteLogicaNegocio tipocomprobanteLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();




        public int InsertarTipoComprobante(Dominio.Dtos.TipoComprobanteDTO dto)
        {
            try
            {
                return tipocomprobanteLogicaNegocio.InsertarTipoComprobante(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarTipoComprobante(Dominio.Dtos.TipoComprobanteDTO dto)
        {
            try
            {
                return tipocomprobanteLogicaNegocio.ActualizarTipoComprobante(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarTipoComprobante(int IDTipoComprobante)
        {
            try
            {
                return tipocomprobanteLogicaNegocio.EliminarTipoComprobante(IDTipoComprobante);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.TipoComprobanteDTO BuscarTipoComprobantePorNombre(string NombreComprobante)
        {
            try
            {
                return tipocomprobanteLogicaNegocio.BuscarTipoComprobantePorNombre(NombreComprobante);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.TipoComprobanteDTO BuscarTipoComprobantePorID(int IDTipoComprobante)
        {
            try
            {
                return tipocomprobanteLogicaNegocio.BuscarTipoComprobantePorID(IDTipoComprobante);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.TipoComprobanteDTO> ListarTodosLosTiposDeComprobante()
        {
            try
            {
                return tipocomprobanteLogicaNegocio.ListarTodosLosTiposDeComprobante();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}