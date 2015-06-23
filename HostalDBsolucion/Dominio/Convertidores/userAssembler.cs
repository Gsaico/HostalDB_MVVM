//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:56:07
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
    /// Assembler for <see cref="user"/> and <see cref="userDTO"/>.
    /// </summary>
    public static partial class userAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="userDTO"/> converted from <see cref="user"/>.</param>
        static partial void OnDTO(this user entity, userDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="user"/> converted from <see cref="userDTO"/>.</param>
        static partial void OnEntity(this userDTO dto, user entity);

        /// <summary>
        /// Converts this instance of <see cref="userDTO"/> to an instance of <see cref="user"/>.
        /// </summary>
        /// <param name="dto"><see cref="userDTO"/> to convert.</param>
        public static user ToEntity(this userDTO dto)
        {
            if (dto == null) return null;

            var entity = new user();

            entity.user_id = dto.user_id;
            entity.username = dto.username;
            entity.password = dto.password;
            entity.email = dto.email;
            entity.dni = dto.dni;
            entity.nombre = dto.nombre;
            entity.apellidos = dto.apellidos;
            entity.direccion = dto.direccion;
            entity.telefono = dto.telefono;
            entity.enabled = dto.enabled;
            entity.accountExpired = dto.accountExpired;
            entity.accountLocked = dto.accountLocked;
            entity.passwordExpired = dto.passwordExpired;
            entity.RUC = dto.RUC;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="user"/> to an instance of <see cref="userDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="user"/> to convert.</param>
        public static userDTO ToDTO(this user entity)
        {
            if (entity == null) return null;

            var dto = new userDTO();

            dto.user_id = entity.user_id;
            dto.username = entity.username;
            dto.password = entity.password;
            dto.email = entity.email;
            dto.dni = entity.dni;
            dto.nombre = entity.nombre;
            dto.apellidos = entity.apellidos;
            dto.direccion = entity.direccion;
            dto.telefono = entity.telefono;
            dto.enabled = entity.enabled;
            dto.accountExpired = entity.accountExpired;
            dto.accountLocked = entity.accountLocked;
            dto.passwordExpired = entity.passwordExpired;
            dto.RUC = entity.RUC;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="userDTO"/> to an instance of <see cref="user"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<user> ToEntities(this IEnumerable<userDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="user"/> to an instance of <see cref="userDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<userDTO> ToDTOs(this IEnumerable<user> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }


        public static void Actualizar(Dominio.Dtos.userDTO  dto, PersistenciaDatos.user  entity)
        {
            entity.user_id = dto.user_id;
            entity.username = dto.username;
            entity.password = dto.password;
            entity.email = dto.email;
            entity.dni = dto.dni;
            entity.nombre = dto.nombre;
            entity.apellidos = dto.apellidos;
            entity.direccion = dto.direccion;
            entity.telefono = dto.telefono;
            entity.enabled = dto.enabled;
            entity.accountExpired = dto.accountExpired;
            entity.accountLocked = dto.accountLocked;
            entity.passwordExpired = dto.passwordExpired;
            entity.RUC = dto.RUC;
        }
    }
}