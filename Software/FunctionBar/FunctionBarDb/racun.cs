//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunctionBarDb
{
    using System;
    using System.Collections.Generic;
    
    public partial class racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public racun()
        {
            this.stavka_racuna = new HashSet<stavka_racuna>();
        }
    
        public int ID { get; set; }
        public System.DateTime datum { get; set; }
        public long id_zaposlenik { get; set; }
        public Nullable<bool> storniran { get; set; }
    
        public virtual zaposlenik zaposlenik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavka_racuna> stavka_racuna { get; set; }
    }
}
