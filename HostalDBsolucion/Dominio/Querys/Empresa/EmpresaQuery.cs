using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Empresa.IEmpresaQuery 
    {

        public bool InsertarEmpresa(Dtos.EmpresaDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.Empresa .Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarEmpresa(Dtos.EmpresaDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.Empresa.Where(q => q.RUC == dto.RUC).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.EmpresaAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarEmpresa(string RUC)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.Empresa x = modelo.Empresa.Where(q => q.RUC == RUC).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.Empresa .Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.EmpresaDTO> BuscarEmpresasPorRazonSocial(string parametroRazonSocial)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.Empresa.Where(q => q.RazonSocial.Contains(parametroRazonSocial)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.EmpresaAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public Dtos.EmpresaDTO BuscarEmpresaPorRUC(string RUC)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.Empresa.Where(q => q.RUC == RUC).Select(q => q).FirstOrDefault ();

                    if (entity == null) return null;
                    return Dominio.Convertidores.EmpresaAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.EmpresaDTO> ListarTodasLasEmpresas()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.Empresa.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.EmpresaAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
