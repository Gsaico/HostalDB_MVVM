//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:56:03
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Dominio.Dtos
{
    [DataContract()]
    public partial class user_roleDTO
    {
        [DataMember()]
        public Int32 id { get; set; }

        [DataMember()]
        public Int32 user_id { get; set; }

        [DataMember()]
        public Int32 role_id { get; set; }

        [DataMember()]
        public roleDTO role { get; set; }

        [DataMember()]
        public userDTO user { get; set; }

        public user_roleDTO()
        {
        }

        public user_roleDTO(Int32 id, Int32 user_id, Int32 role_id, roleDTO role, userDTO user)
        {
			this.id = id;
			this.user_id = user_id;
			this.role_id = role_id;
			this.role = role;
			this.user = user;
        }
    }
}