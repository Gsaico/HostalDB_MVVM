//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:56:00
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
    public partial class llamadaDTO
    {
        [DataMember()]
        public Int32 llamada_id { get; set; }

        [DataMember()]
        public Int32 reserva_id { get; set; }

        [DataMember()]
        public Int32 habitacion_id { get; set; }

        [DataMember()]
        public Int32 tipo_llamada_id { get; set; }

        [DataMember()]
        public Nullable<Double> minutos { get; set; }

        [DataMember()]
        public habitacionDTO habitacion { get; set; }

        [DataMember()]
        public tipo_llamadaDTO tipo_llamada { get; set; }

        public llamadaDTO()
        {
        }

        public llamadaDTO(Int32 llamada_id, Int32 reserva_id, Int32 habitacion_id, Int32 tipo_llamada_id, Nullable<Double> minutos, habitacionDTO habitacion, tipo_llamadaDTO tipo_llamada)
        {
			this.llamada_id = llamada_id;
			this.reserva_id = reserva_id;
			this.habitacion_id = habitacion_id;
			this.tipo_llamada_id = tipo_llamada_id;
			this.minutos = minutos;
			this.habitacion = habitacion;
			this.tipo_llamada = tipo_llamada;
        }
    }
}