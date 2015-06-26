using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Comprobante.IComprobanteLogicaNegocio 
    {
        Dominio.Querys.Comprobante.IComprobanteQuery comprobanteQuerys = new Dominio.Querys.Querys();


        public bool InsertarComprobante(Dominio.Dtos.comprobanteDTO dto)
        {
            try
            {
                return comprobanteQuerys.InsertarComprobante(dto);
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
                return comprobanteQuerys.ActualizarComprobante(dto);
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
                return comprobanteQuerys.EliminarComprobante(id);
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
                return comprobanteQuerys.BuscarComprobantePorID(id);
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
                return comprobanteQuerys.ListarComprobantesPorIDCLIENTE(idcliente);
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
                return comprobanteQuerys.BuscarComprobantePorIDRESERVA(idreserva);
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
                return comprobanteQuerys.ListarTodosLosComprobantes();
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
                return comprobanteQuerys.ListarComprobantesPorTIPOCOMPROBANTE(idcomprobante);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
