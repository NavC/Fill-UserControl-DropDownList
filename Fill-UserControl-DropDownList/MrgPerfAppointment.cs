namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MrgPerfAppointment")]
    public partial class MrgPerfAppointment
    {
        [Key]
        public int appointment_id { get; set; }

        public DateTime appointmentdt { get; set; }

        [StringLength(50)]
        public string hfirst { get; set; }

        [StringLength(50)]
        public string hlast { get; set; }

        [StringLength(50)]
        public string wfirst { get; set; }

        [StringLength(50)]
        public string wlast { get; set; }

        [StringLength(10)]
        public string hphone { get; set; }

        [StringLength(10)]
        public string wphone { get; set; }

        [StringLength(25)]
        public string countid { get; set; }

        public byte ceremonystatus_id { get; set; }

        public byte timestatus_id { get; set; }

        public int schedule_id { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }
    }
}
