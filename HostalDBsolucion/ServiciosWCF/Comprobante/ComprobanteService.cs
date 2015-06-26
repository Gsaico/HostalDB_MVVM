using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class HostalDB_ServiceWCF : Comprobante.IComprobanteService 
    {
        LogicaDeNegocios.Comprobante.IComprobanteLogicaNegocio comprobanteLogicaNegocio = new LogicaDeNegocios.HostalDB_LogicaNegocio();




        public bool InsertarComprobante(Dominio.Dtos.comprobanteDTO dto)
        {
            try
            {
                return comprobanteLogicaNegocio.InsertarComprobante(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarComprobante(Dominio.Dtos.comprobanteDTO dto)
        {
            try
            {
                return comprobanteLogicaNegocio.ActualizarComprobante(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarComprobante(int id)
        {
            try
            {
                return comprobanteLogicaNegocio.EliminarComprobante(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.comprobanteDTO BuscarComprobantePorID(int id)
        {
            try
            {
                return comprobanteLogicaNegocio.BuscarComprobantePorID(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.comprobanteDTO> ListarComprobantesPorIDCLIENTE(int idcliente)
        {
            try
            {
                return comprobanteLogicaNegocio.ListarComprobantesPorIDCLIENTE(idcliente);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.comprobanteDTO BuscarComprobantePorIDRESERVA(int idreserva)
        {
            try
            {
                return comprobanteLogicaNegocio.BuscarComprobantePorIDRESERVA(idreserva);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.comprobanteDTO> ListarTodosLosComprobantes()
        {
            try
            {
                return comprobanteLogicaNegocio.ListarTodosLosComprobantes();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.comprobanteDTO> ListarComprobantesPorTIPOCOMPROBANTE(int idcomprobante)
        {
            try
            {
                return comprobanteLogicaNegocio.ListarComprobantesPorTIPOCOMPROBANTE(idcomprobante);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}