//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace traveling.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class trip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trip()
        {
            this.posts = new HashSet<post>();
        }
        public string file { get; set; }
        public int tripID { get; set; }
        public string tripPrice { get; set; }
        public string tripDetails { get; set; }
        public System.DateTime tripDate { get; set; }
        public string tripImagePath { get; set; }
        public string tripDestination { get; set; }
        public string tripTitle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<post> posts { get; set; }
    }
}
