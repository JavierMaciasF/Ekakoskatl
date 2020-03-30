namespace Ekakoskatl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PermissionRole
    {
        [Key]
        public Guid PermissionRolID { get; set; }

        public DateTime PermissionRolDateCreate { get; set; }

        public DateTime PermissionRolDateModified { get; set; }

        public int PermissionRolSelect { get; set; }

        public int PermissionRolUpdate { get; set; }

        public int PermissionRolDelete { get; set; }

        public int PermissionRolInsert { get; set; }

        public int PermissionRolGrant { get; set; }

        public Guid RolID { get; set; }

        public Guid PermissionID { get; set; }

        public virtual Permission Permission { get; set; }

        public virtual Role Role { get; set; }
    }
}
