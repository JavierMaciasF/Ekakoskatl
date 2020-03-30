namespace Ekakoskatl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenuItem
    {
        public Guid MenuItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string MenuItemName { get; set; }

        [Required]
        [StringLength(50)]
        public string MenuItemRoute { get; set; }

        public DateTime MenuItemDateCreate { get; set; }

        public DateTime MenuItemDateModified { get; set; }

        public Guid? MenuItemParentID { get; set; }

        [StringLength(4)]
        public string MenuItemFormID { get; set; }

        public int MenuItemType { get; set; }

        public int MenuItemOrder { get; set; }

        public Guid PermissionID { get; set; }

        public int PermissionTypeAction { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] MenuItemIcon { get; set; }

        public virtual Permission Permission { get; set; }
    }
}
