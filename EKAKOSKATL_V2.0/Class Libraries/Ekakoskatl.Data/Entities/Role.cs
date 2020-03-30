namespace Ekakoskatl.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Role()
        {
            PermissionRoles = new HashSet<PermissionRole>();
        }

        [Key]
        public Guid RolID { get; set; }

        [Required]
        [StringLength(50)]
        public string RolName { get; set; }

        public DateTime RolDateCreate { get; set; }

        public Guid UserID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }

        public virtual User User { get; set; }
    }
}
