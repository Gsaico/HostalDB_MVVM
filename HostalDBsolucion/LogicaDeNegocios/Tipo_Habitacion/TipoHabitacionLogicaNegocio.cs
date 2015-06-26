using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class HostalDB_LogicaNegocio : Tipo_Habitacion.ITipoHabitacionLogicaNegocio  
    {
        Dominio.Querys.Tipo_Habitacion.ITipo_HabitacionQuery tipohabitacionQuerys = new Dominio.Querys.Querys();


        public int InsertarTipoHabitacion(Dominio.Dtos.tipo_habitacionDTO dto)
        {
            try
            {
                return tipohabitacionQuerys.InsertarTipoHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarTipoHabitacion(Dominio.Dtos.tipo_habitacionDTO dto)
        {
            try
            {
                return tipohabitacionQuerys.ActualizarTipoHabitacion(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarTipoHabitacion(int id_tipo_habitacion)
        {
            try
            {
                return tipohabitacionQuerys.EliminarTipoHabitacion(id_tipo_habitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorID(int id_tipo_habitacion)
        {
            try
            {
                return tipohabitacionQuerys.BuscarTipoHabitacionPorID(id_tipo_habitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.tipo_habitacionDTO BuscarTipoHabitacionPorNombre(string ParamentroNombreHabitacion)
        {
            try
            {
                return tipohabitacionQuerys.BuscarTipoHabitacionPorNombre(ParamentroNombreHabitacion);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.tipo_habitacionDTO> ListarTodosLos_TiposHabitacion()
        {
            try
            {
                return tipohabitacionQuerys.ListarTodosLos_TiposHabitacion();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
