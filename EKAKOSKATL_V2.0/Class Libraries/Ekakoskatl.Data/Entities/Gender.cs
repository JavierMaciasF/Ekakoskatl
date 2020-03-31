namespace Ekakoskatl.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gender")]
    public partial class Gender
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gender()
        {
            VideoGenders = new HashSet<VideoGender>();
        }

        public Guid GenderID { get; set; }

        [Required]
        [StringLength(150)]
        public string GenderName { get; set; }

        public DateTime GenderDateCreate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoGender> VideoGenders { get; set; }
    }
}
