//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VuelaWebApp.Models
{
    using System;
    
    public partial class consultaFitradaVuelos_Result
    {
        public int idlineavuelo { get; set; }
        public System.DateTime horapartida { get; set; }
        public System.DateTime horallegada { get; set; }
        public Nullable<decimal> cantescalas { get; set; }
        public Nullable<decimal> precio { get; set; }
        public string paisOrigen { get; set; }
        public string paisDestino { get; set; }
    }
}
