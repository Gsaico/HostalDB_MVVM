using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
    public partial class Querys : Comprobante.IComprobanteQuery  
    {

        public bool InsertarComprobante(Dtos.comprobanteDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.comprobante.Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarComprobante(Dtos.comprobanteDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.comprobante.Where(q => q.id  == dto.id).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.comprobanteAssembler .Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
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
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.comprobante x = modelo.comprobante.Where(q => q.id == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.comprobante.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.comprobanteDTO BuscarComprobantePorID(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.comprobante.Where(q => q.id == id).Select(q => q).FirstOrDefault ();

                    if (entity == null) return null;
                    return Dominio.Convertidores.comprobanteAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.comprobanteDTO> ListarComprobantesPorIDCLIENTE(int idcliente)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.comprobante.Where(q => q.cliente_id == idcliente).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.comprobanteAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public Dtos.comprobanteDTO BuscarComprobantePorIDRESERVA(int idreserva)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.comprobante.Where(q => q.reserva_id == idreserva).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.comprobanteAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.comprobanteDTO> ListarTodosLosComprobantes()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.comprobante.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.comprobanteAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.comprobanteDTO> ListarComprobantesPorTIPOCOMPROBANTE(int idcomprobante)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.comprobante.Where(q => q.idcomprobante == idcomprobante).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.comprobanteAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
