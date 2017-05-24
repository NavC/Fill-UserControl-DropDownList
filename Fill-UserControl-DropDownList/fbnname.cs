namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fbnname")]
    public partial class fbnname
    {
        public int fbnnameid { get; set; }

        public int fbnid { get; set; }

        public int? linenum { get; set; }

        [StringLength(100)]
        public string fbname { get; set; }

        public bool internet { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        public byte agentregistrant { get; set; }

        [StringLength(100)]
        public string agentname { get; set; }

        [StringLength(100)]
        public string agentaddress { get; set; }

        public int? agentidtype { get; set; }

        [StringLength(50)]
        public string agentidtypeother { get; set; }

        [StringLength(50)]
        public string agentidnumber { get; set; }

        [StringLength(17)]
        public string agentphone { get; set; }

        public virtual fbninfo fbninfo { get; set; }
    }
}
