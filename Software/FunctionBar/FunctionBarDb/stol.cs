
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
    
public partial class stol
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public stol()
    {

        this.rezervacijas = new HashSet<rezervacija>();

    }


    public int ID { get; set; }

    public Nullable<int> broj_mjesta { get; set; }

    public Nullable<int> id_rezervacije { get; set; }

    public int id_vrsta_stola { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<rezervacija> rezervacijas { get; set; }

    public virtual vrsta_stola vrsta_stola { get; set; }

}

}
