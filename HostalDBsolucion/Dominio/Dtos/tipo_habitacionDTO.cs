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
    public partial class tipo_habitacionDTO
    {
        [DataMember()]
        public Int32 tipo_habitacion_id { get; set; }

        [DataMember()]
        public String nombre { get; set; }

        [DataMember()]
        public Double precio { get; set; }

        [DataMember()]
        public List<habitacionDTO> habitacion { get; set; }

        public tipo_habitacionDTO()
        {
        }

        public tipo_habitacionDTO(Int32 tipo_habitacion_id, String nombre, Double precio, List<habitacionDTO> habitacion)
        {
			this.tipo_habitacion_id = tipo_habitacion_id;
			this.nombre = nombre;
			this.precio = precio;
			this.habitacion = habitacion;
        }
    }
}
