//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myNotesApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class note
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public note()
        {
            this.categories = new HashSet<category>();
            this.favourites = new HashSet<favourite>();
            this.trashes = new HashSet<trash>();
        }
    
        public int id { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public Nullable<bool> isTrashed { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<category> categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<favourite> favourites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trash> trashes { get; set; }
    }
}
