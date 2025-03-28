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
    
    public partial class Vivienda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vivienda()
        {
            this.Ventas = new HashSet<Venta>();
        }
    
        public int codigo { get; set; }
        public Nullable<int> numBanos { get; set; }
        public Nullable<int> numCuartos { get; set; }
        public Nullable<int> tamano { get; set; }
        public Nullable<int> numPisos { get; set; }
        public string accessories { get; set; }
        public Nullable<double> precio { get; set; }
        public Nullable<int> tipoVi { get; set; }

        [JsonIgnore]
        public virtual TipoVivienda TipoVivienda { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
