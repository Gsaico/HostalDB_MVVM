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
    public partial class TipoComprobanteDTO
    {
        [DataMember()]
        public Int32 idcomprobante { get; set; }

        [DataMember()]
        public String nombrecomprobante { get; set; }

        [DataMember()]
        public List<comprobanteDTO> comprobante { get; set; }

        public TipoComprobanteDTO()
        {
        }

        public TipoComprobanteDTO(Int32 idcomprobante, String nombrecomprobante, List<comprobanteDTO> comprobante)
        {
			this.idcomprobante = idcomprobante;
			this.nombrecomprobante = nombrecomprobante;
			this.comprobante = comprobante;
        }
    }
}