//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:56:02
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
    public partial class tipo_llamadaDTO
    {
        [DataMember()]
        public Int32 tipo_llamada_id { get; set; }

        [DataMember()]
        public String nombre { get; set; }

        [DataMember()]
        public Double precio { get; set; }

        [DataMember()]
        public List<llamadaDTO> llamada { get; set; }

        public tipo_llamadaDTO()
        {
        }

        public tipo_llamadaDTO(Int32 tipo_llamada_id, String nombre, Double precio, List<llamadaDTO> llamada)
        {
			this.tipo_llamada_id = tipo_llamada_id;
			this.nombre = nombre;
			this.precio = precio;
			this.llamada = llamada;
        }
    }
}
