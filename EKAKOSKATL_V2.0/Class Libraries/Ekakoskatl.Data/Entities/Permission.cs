namespace Ekakoskatl.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permission")]
    public partial class Permission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permission()
        {
            MenuItems = new HashSet<MenuItem>();
            PermissionRoles = new HashSet<PermissionRole>();
        }

        public Guid PermissionID { get; set; }

        [Required]
        [StringLength(100)]
        public string PermissionName { get; set; }

        public DateTime PermissionDateCreate { get; set; }

        public DateTime PermissionDateModified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuItem> MenuItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}
