//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:56:01
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
    public partial class roleDTO
    {
        [DataMember()]
        public Int32 role_id { get; set; }

        [DataMember()]
        public String authority { get; set; }

        [DataMember()]
        public List<user_roleDTO> user_role { get; set; }

        public roleDTO()
        {
        }

        public roleDTO(Int32 role_id, String authority, List<user_roleDTO> user_role)
        {
			this.role_id = role_id;
			this.authority = authority;
			this.user_role = user_role;
        }
    }
}
