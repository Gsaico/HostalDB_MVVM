using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Hotel.IHotelQuery
    {

        public int InsertarHotel(Dtos.hotelDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.hotel.Add(entity);
                    modelo.SaveChanges();
                    return entity.hotel_id ;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarHotel(Dtos.hotelDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var w = modelo.hotel.Where(q => q.hotel_id == dto.hotel_id).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.hotelAssembler .Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarHotel(int IDHotel)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    PersistenciaDatos.hotel x = modelo.hotel.Where(q => q.hotel_id  == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.hotel.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.hotelDTO BuscarHotelPorID(int IDHotel)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.hotel.Where(q => q.hotel_id  == IDHotel).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.hotelAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public Dtos.hotelDTO BuscarHotelPorNombre(string parametro)
        {
        
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.hotel.Where(q => q.nombre.Contains(parametro)).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.hotelAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.hotelDTO> ListarTodosLosHoteles()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.HostalDBEntities())
                {
                    var entity = modelo.hotel.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.hotelAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
