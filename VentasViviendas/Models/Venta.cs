//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentasViviendas.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int codigo { get; set; }
        public Nullable<System.DateTime> fechaCompra { get; set; }
        public Nullable<double> valor { get; set; }
        public Nullable<int> cliente { get; set; }
        public Nullable<int> agencia { get; set; }
        public Nullable<int> vivienda { get; set; }

        [JsonIgnore]
        public virtual Agencia Agencia1 { get; set; }
        [JsonIgnore]
        public virtual Cliente Cliente1 { get; set; }
        [JsonIgnore]
        public virtual Vivienda Vivienda1 { get; set; }
    }
}
