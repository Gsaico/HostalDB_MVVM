//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:56:04
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Dominio.Dtos;
using PersistenciaDatos;

namespace Dominio.Convertidores
{

    /// <summary>
    /// Assembler for <see cref="comprobante"/> and <see cref="comprobanteDTO"/>.
    /// </summary>
    public static partial class comprobanteAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="comprobanteDTO"/> converted from <see cref="comprobante"/>.</param>
        static partial void OnDTO(this comprobante entity, comprobanteDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="comprobante"/> converted from <see cref="comprobanteDTO"/>.</param>
        static partial void OnEntity(this comprobanteDTO dto, comprobante entity);

        /// <summary>
        /// Converts this instance of <see cref="comprobanteDTO"/> to an instance of <see cref="comprobante"/>.
        /// </summary>
        /// <param name="dto"><see cref="comprobanteDTO"/> to convert.</param>
        public static comprobante ToEntity(this comprobanteDTO dto)
        {
            if (dto == null) return null;

            var entity = new comprobante();

            entity.id = dto.id;
            entity.cliente_id = dto.cliente_id;
            entity.reserva_id = dto.reserva_id;
            entity.costeHabitacion = dto.costeHabitacion;
            entity.costeLlamadas = dto.costeLlamadas;
            entity.costeMinibar = dto.costeMinibar;
            entity.costeConsumibles = dto.costeConsumibles;
            entity.RUCcliente = dto.RUCcliente;
            entity.idcomprobante = dto.idcomprobante;
            entity.FechaeEmision = dto.FechaeEmision;
            entity.estado = dto.estado;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="comprobante"/> to an instance of <see cref="comprobanteDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="comprobante"/> to convert.</param>
        public static comprobanteDTO ToDTO(this comprobante entity)
        {
            if (entity == null) return null;

            var dto = new comprobanteDTO();

            dto.id = entity.id;
            dto.cliente_id = entity.cliente_id;
            dto.reserva_id = entity.reserva_id;
            dto.costeHabitacion = entity.costeHabitacion;
            dto.costeLlamadas = entity.costeLlamadas;
            dto.costeMinibar = entity.costeMinibar;
            dto.costeConsumibles = entity.costeConsumibles;
            dto.RUCcliente = entity.RUCcliente;
            dto.idcomprobante = entity.idcomprobante;
            dto.FechaeEmision = entity.FechaeEmision;
            dto.estado = entity.estado;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="comprobanteDTO"/> to an instance of <see cref="comprobante"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<comprobante> ToEntities(this IEnumerable<comprobanteDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="comprobante"/> to an instance of <see cref="comprobanteDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<comprobanteDTO> ToDTOs(this IEnumerable<comprobante> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
        public static void Actualizar(Dominio.Dtos.comprobanteDTO dto, PersistenciaDatos.comprobante entity)
        {
            entity.id = dto.id;
            entity.cliente_id = dto.cliente_id;
            entity.reserva_id = dto.reserva_id;
            entity.costeHabitacion = dto.costeHabitacion;
            entity.costeLlamadas = dto.costeLlamadas;
            entity.costeMinibar = dto.costeMinibar;
            entity.costeConsumibles = dto.costeConsumibles;
            entity.RUCcliente = dto.RUCcliente;
            entity.idcomprobante = dto.idcomprobante;
            entity.FechaeEmision = dto.FechaeEmision;
            entity.estado = dto.estado;

        }
    }
}
