//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chinmaya.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CM_Centers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CM_Centers()
        {
            this.CM_Users = new HashSet<CM_Users>();
        }
    
        public System.Guid CenterGUID { get; set; }
        public System.Guid CityGUID { get; set; }
        public string CenterCode { get; set; }
        public string CenterName { get; set; }
        public string CenterDescription { get; set; }
        public string ContactAddresss { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmailId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public bool Active { get; set; }
    
        public virtual CM_Cities CM_Cities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CM_Users> CM_Users { get; set; }
    }
}
