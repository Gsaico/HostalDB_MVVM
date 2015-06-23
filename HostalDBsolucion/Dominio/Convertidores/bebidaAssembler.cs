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
    /// Assembler for <see cref="bebida"/> and <see cref="bebidaDTO"/>.
    /// </summary>
    public static partial class bebidaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="bebidaDTO"/> converted from <see cref="bebida"/>.</param>
        static partial void OnDTO(this bebida entity, bebidaDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="bebida"/> converted from <see cref="bebidaDTO"/>.</param>
        static partial void OnEntity(this bebidaDTO dto, bebida entity);

        /// <summary>
        /// Converts this instance of <see cref="bebidaDTO"/> to an instance of <see cref="bebida"/>.
        /// </summary>
        /// <param name="dto"><see cref="bebidaDTO"/> to convert.</param>
        public static bebida ToEntity(this bebidaDTO dto)
        {
            if (dto == null) return null;

            var entity = new bebida();

            entity.bebida_id = dto.bebida_id;
            entity.precio = dto.precio;
            entity.nombre = dto.nombre;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="bebida"/> to an instance of <see cref="bebidaDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="bebida"/> to convert.</param>
        public static bebidaDTO ToDTO(this bebida entity)
        {
            if (entity == null) return null;

            var dto = new bebidaDTO();

            dto.bebida_id = entity.bebida_id;
            dto.precio = entity.precio;
            dto.nombre = entity.nombre;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="bebidaDTO"/> to an instance of <see cref="bebida"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<bebida> ToEntities(this IEnumerable<bebidaDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="bebida"/> to an instance of <see cref="bebidaDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<bebidaDTO> ToDTOs(this IEnumerable<bebida> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
        public static void Actualizar(Dominio.Dtos.bebidaDTO dto, PersistenciaDatos.bebida entity)
        {
            entity.bebida_id = dto.bebida_id;
            entity.precio = dto.precio;
            entity.nombre = dto.nombre;

        }
    }
}