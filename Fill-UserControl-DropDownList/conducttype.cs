namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class conducttype
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int condtype_id { get; set; }

        public int? module_id { get; set; }

        [StringLength(40)]
        public string condtype_name { get; set; }

        public int? personnumid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int state_inc_needed { get; set; }

        [StringLength(200)]
        public string persontypes { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isdefaultvalue { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp_column { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte allowpicture { get; set; }
    }
}
