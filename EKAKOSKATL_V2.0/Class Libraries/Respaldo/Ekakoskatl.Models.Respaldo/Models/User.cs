namespace Ekakoskatl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            RecentlySeens = new HashSet<RecentlySeen>();
            Roles = new HashSet<Role>();
        }

        public Guid UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserLastName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserDisplayName { get; set; }

        [Required]
        [StringLength(100)]
        public string UserEMail { get; set; }

        public int? UserAge { get; set; }

        public DateTime UserDateCreate { get; set; }

        public DateTime UserDateModified { get; set; }

        public string UserPasswordToken { get; set; }

        public DateTime? UserPasswordTokenExp { get; set; }

        public bool? UserResetTokenNextTime { get; set; }

        public bool? UserResetPasswordNextTime { get; set; }

        [Column(TypeName = "image")]
        public byte[] UserImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecentlySeen> RecentlySeens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}
