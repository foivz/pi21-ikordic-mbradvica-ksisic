
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
    
public partial class vrsta_uloge
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public vrsta_uloge()
    {

        this.zaposleniks = new HashSet<zaposlenik>();

    }


    public int ID { get; set; }

    public string naziv { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<zaposlenik> zaposleniks { get; set; }

}

}
