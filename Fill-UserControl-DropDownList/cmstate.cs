namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cmstate
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(13)]
        public string cmstatesid { get; set; }

        [StringLength(2)]
        public string code { get; set; }

        [StringLength(40)]
        public string state { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp_column { get; set; }
    }
}
