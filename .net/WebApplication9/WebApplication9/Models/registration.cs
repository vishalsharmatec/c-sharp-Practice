namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("registration")]
    public partial class registration
    {
        public int id { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        public int? course_id { get; set; }

        public int? batch__id { get; set; }

        public int? telno { get; set; }

        public virtual batch batch { get; set; }

        public virtual course course { get; set; }
    }
}
