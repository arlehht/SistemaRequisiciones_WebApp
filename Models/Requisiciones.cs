//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaRequisiciones_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requisiciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requisiciones()
        {
            this.Productos = new HashSet<Productos>();
        }
    
        public int NoRequisicion { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Area { get; set; }
        public string Tipo { get; set; }
        public string EntregarEn { get; set; }
        public string Prioridad { get; set; }
        public System.DateTime FechaSurtido { get; set; }
        public string CompraServicio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> Productos { get; set; }
    }
}