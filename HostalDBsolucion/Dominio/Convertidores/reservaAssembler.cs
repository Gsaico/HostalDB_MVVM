//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:56:05
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
    /// Assembler for <see cref="reserva"/> and <see cref="reservaDTO"/>.
    /// </summary>
    public static partial class reservaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="reservaDTO"/> converted from <see cref="reserva"/>.</param>
        static partial void OnDTO(this reserva entity, reservaDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="reserva"/> converted from <see cref="reservaDTO"/>.</param>
        static partial void OnEntity(this reservaDTO dto, reserva entity);

        /// <summary>
        /// Converts this instance of <see cref="reservaDTO"/> to an instance of <see cref="reserva"/>.
        /// </summary>
        /// <param name="dto"><see cref="reservaDTO"/> to convert.</param>
        public static reserva ToEntity(this reservaDTO dto)
        {
            if (dto == null) return null;

            var entity = new reserva();

            entity.reserva_id = dto.reserva_id;
            entity.cliente_id = dto.cliente_id;
            entity.fecha_inicio = dto.fecha_inicio;
            entity.fecha_fin = dto.fecha_fin;
            entity.fecha_reserva = dto.fecha_reserva;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="reserva"/> to an instance of <see cref="reservaDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="reserva"/> to convert.</param>
        public static reservaDTO ToDTO(this reserva entity)
        {
            if (entity == null) return null;

            var dto = new reservaDTO();

            dto.reserva_id = entity.reserva_id;
            dto.cliente_id = entity.cliente_id;
            dto.fecha_inicio = entity.fecha_inicio;
            dto.fecha_fin = entity.fecha_fin;
            dto.fecha_reserva = entity.fecha_reserva;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="reservaDTO"/> to an instance of <see cref="reserva"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<reserva> ToEntities(this IEnumerable<reservaDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="reserva"/> to an instance of <see cref="reservaDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<reservaDTO> ToDTOs(this IEnumerable<reserva> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
        public static void Actualizar(Dominio.Dtos.reservaDTO dto, PersistenciaDatos.reserva entity)
        {
            entity.reserva_id = dto.reserva_id;
            entity.cliente_id = dto.cliente_id;
            entity.fecha_inicio = dto.fecha_inicio;
            entity.fecha_fin = dto.fecha_fin;
            entity.fecha_reserva = dto.fecha_reserva;

        }
    }
}
