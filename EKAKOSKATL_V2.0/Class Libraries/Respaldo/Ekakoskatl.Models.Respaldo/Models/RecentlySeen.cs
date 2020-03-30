namespace Ekakoskatl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecentlySeen")]
    public partial class RecentlySeen
    {
        public Guid RecentlySeenID { get; set; }

        public DateTime RecentlySeenDateCreate { get; set; }

        public Guid VideoID { get; set; }

        public Guid UserID { get; set; }

        public virtual User User { get; set; }

        public virtual Video Video { get; set; }
    }
}
