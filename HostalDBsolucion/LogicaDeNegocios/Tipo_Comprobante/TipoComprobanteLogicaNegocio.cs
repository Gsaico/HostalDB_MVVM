using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Tipo_Comprobante.ITipoComprobanteLogicaNegocio 
    {
        Dominio.Querys.Tipo_Comprobante.ITipoComprobanteQuery   tipocomprobanteQuerys = new Dominio.Querys.Querys();


        public int InsertarTipoComprobante(Dominio.Dtos.TipoComprobanteDTO dto)
        {
            try
            {
                return tipocomprobanteQuerys.InsertarTipoComprobante(dto);
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
                return tipocomprobanteQuerys.ActualizarTipoComprobante(dto);
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
                return tipocomprobanteQuerys.EliminarTipoComprobante(IDTipoComprobante);
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
                return tipocomprobanteQuerys.BuscarTipoComprobantePorNombre(NombreComprobante);
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
                return tipocomprobanteQuerys.BuscarTipoComprobantePorID(IDTipoComprobante);
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
                return tipocomprobanteQuerys.ListarTodosLosTiposDeComprobante();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
