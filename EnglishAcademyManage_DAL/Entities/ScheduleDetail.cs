namespace EnglishAcademyManage_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ScheduleDetail
    {
        [Key]
        [StringLength(10)]
        public string schedule_id { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        [StringLength(10)]
        public string room { get; set; }

        [Required]
        [StringLength(10)]
        public string class_id { get; set; }

        public virtual Class Class { get; set; }
    }
}
