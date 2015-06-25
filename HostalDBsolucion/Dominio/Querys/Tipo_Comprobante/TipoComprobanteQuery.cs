using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
    public partial class Querys : Tipo_Comprobante.ITipoComprobanteQuery
    {

        public int InsertarTipoComprobante(Dtos.TipoComprobanteDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.TipoComprobante.Add(entity);
                    modelo.SaveChanges();
                    return entity.idcomprobante;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarTipoComprobante(Dtos.TipoComprobanteDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.TipoComprobante.Where(q => q.idcomprobante == dto.idcomprobante).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.TipoComprobanteAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
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
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.TipoComprobante x = modelo.TipoComprobante.Where(q => q.idcomprobante == IDTipoComprobante).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.TipoComprobante.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.TipoComprobanteDTO BuscarTipoComprobantePorNombre(string NombreComprobante)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.TipoComprobante.Where(q => q.nombrecomprobante.Contains(NombreComprobante)).Select(q => q).FirstOrDefault ();

                    if (entity == null) return null;
                    return Dominio.Convertidores.TipoComprobanteAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public Dtos.TipoComprobanteDTO BuscarTipoComprobantePorID(int IDTipoComprobante)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.TipoComprobante.Where(q => q.idcomprobante == IDTipoComprobante).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.TipoComprobanteAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.TipoComprobanteDTO> ListarTodosLosTiposDeComprobante()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.TipoComprobante.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.TipoComprobanteAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
