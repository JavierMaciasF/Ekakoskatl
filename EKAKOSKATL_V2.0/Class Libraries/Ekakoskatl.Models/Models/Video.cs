namespace BusinessEntities.BasicEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Video
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Video()
        {
            RecentlySeens = new HashSet<RecentlySeen>();
            VideoGenders = new HashSet<VideoGender>();
        }

        public Guid VideoID { get; set; }

        [Required]
        [StringLength(150)]
        public string VideoName { get; set; }

        [Required]
        [StringLength(500)]
        public string VideoDescription { get; set; }

        public DateTime VideoDateCreate { get; set; }

        public DateTime VideoDateMocdified { get; set; }

        public int VideoGender { get; set; }

        [Column(TypeName = "image")]
        public byte[] VideoImage { get; set; }

        [StringLength(150)]
        public string VideoRoute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecentlySeen> RecentlySeens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoGender> VideoGenders { get; set; }
    }
}
