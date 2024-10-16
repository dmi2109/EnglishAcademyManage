namespace EnglishAcademyManage_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            ScheduleDetails = new HashSet<ScheduleDetail>();
        }

        [Key]
        [StringLength(10)]
        public string class_id { get; set; }

        [Required]
        [StringLength(10)]
        public string course_id { get; set; }

        [Required]
        [StringLength(10)]
        public string teacher_id { get; set; }

        [StringLength(50)]
        public string class_name { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public decimal? price { get; set; }

        public virtual Course Course { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduleDetail> ScheduleDetails { get; set; }
    }
}
