//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:56:06
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
    /// Assembler for <see cref="reserva_habitacion"/> and <see cref="reserva_habitacionDTO"/>.
    /// </summary>
    public static partial class reserva_habitacionAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="reserva_habitacionDTO"/> converted from <see cref="reserva_habitacion"/>.</param>
        static partial void OnDTO(this reserva_habitacion entity, reserva_habitacionDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="reserva_habitacion"/> converted from <see cref="reserva_habitacionDTO"/>.</param>
        static partial void OnEntity(this reserva_habitacionDTO dto, reserva_habitacion entity);

        /// <summary>
        /// Converts this instance of <see cref="reserva_habitacionDTO"/> to an instance of <see cref="reserva_habitacion"/>.
        /// </summary>
        /// <param name="dto"><see cref="reserva_habitacionDTO"/> to convert.</param>
        public static reserva_habitacion ToEntity(this reserva_habitacionDTO dto)
        {
            if (dto == null) return null;

            var entity = new reserva_habitacion();

            entity.id = dto.id;
            entity.reserva_id = dto.reserva_id;
            entity.habitacion_id = dto.habitacion_id;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="reserva_habitacion"/> to an instance of <see cref="reserva_habitacionDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="reserva_habitacion"/> to convert.</param>
        public static reserva_habitacionDTO ToDTO(this reserva_habitacion entity)
        {
            if (entity == null) return null;

            var dto = new reserva_habitacionDTO();

            dto.id = entity.id;
            dto.reserva_id = entity.reserva_id;
            dto.habitacion_id = entity.habitacion_id;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="reserva_habitacionDTO"/> to an instance of <see cref="reserva_habitacion"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<reserva_habitacion> ToEntities(this IEnumerable<reserva_habitacionDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="reserva_habitacion"/> to an instance of <see cref="reserva_habitacionDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<reserva_habitacionDTO> ToDTOs(this IEnumerable<reserva_habitacion> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
        public static void Actualizar(Dominio.Dtos.reserva_habitacionDTO dto, PersistenciaDatos.reserva_habitacion entity)
        {
            entity.id = dto.id;
            entity.reserva_id = dto.reserva_id;
            entity.habitacion_id = dto.habitacion_id;

        }
    }
}
