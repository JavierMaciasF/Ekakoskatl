namespace Ekakoskatl.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VideoGender")]
    public partial class VideoGender
    {
        public Guid VideoGenderID { get; set; }

        public Guid GenderID { get; set; }

        public Guid VideoID { get; set; }

        public DateTime VideoGenderDateCreate { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Video Video { get; set; }
    }
}
