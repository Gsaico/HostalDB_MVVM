//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/06/15 - 08:55:59
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
    public partial class habitacionDTO
    {
        [DataMember()]
        public Int32 habitacion_id { get; set; }

        [DataMember()]
        public Int32 hotel_id { get; set; }

        [DataMember()]
        public Int32 categoria_id { get; set; }

        [DataMember()]
        public Int32 tipo_habitacion_id { get; set; }

        [DataMember()]
        public Int16 ocupada { get; set; }

        [DataMember()]
        public categoria_habitacionDTO categoria_habitacion { get; set; }

        [DataMember()]
        public List<minibarDTO> minibar { get; set; }

        [DataMember()]
        public hotelDTO hotel { get; set; }

        [DataMember()]
        public tipo_habitacionDTO tipo_habitacion { get; set; }

        [DataMember()]
        public List<llamadaDTO> llamada { get; set; }

        [DataMember()]
        public List<reserva_habitacionDTO> reserva_habitacion { get; set; }

        public habitacionDTO()
        {
        }

        public habitacionDTO(Int32 habitacion_id, Int32 hotel_id, Int32 categoria_id, Int32 tipo_habitacion_id, Int16 ocupada, categoria_habitacionDTO categoria_habitacion, List<minibarDTO> minibar, hotelDTO hotel, tipo_habitacionDTO tipo_habitacion, List<llamadaDTO> llamada, List<reserva_habitacionDTO> reserva_habitacion)
        {
			this.habitacion_id = habitacion_id;
			this.hotel_id = hotel_id;
			this.categoria_id = categoria_id;
			this.tipo_habitacion_id = tipo_habitacion_id;
			this.ocupada = ocupada;
			this.categoria_habitacion = categoria_habitacion;
			this.minibar = minibar;
			this.hotel = hotel;
			this.tipo_habitacion = tipo_habitacion;
			this.llamada = llamada;
			this.reserva_habitacion = reserva_habitacion;
        }
    }
}