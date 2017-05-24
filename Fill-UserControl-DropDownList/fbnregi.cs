namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class fbnregi
    {
        [Key]
        public int registrid { get; set; }

        public int fbnid { get; set; }

        public int? linenum { get; set; }

        [StringLength(100)]
        public string registrnam { get; set; }

        [StringLength(70)]
        public string address { get; set; }

        [StringLength(30)]
        public string city { get; set; }

        [StringLength(2)]
        public string state { get; set; }

        [StringLength(10)]
        public string zip { get; set; }

        [StringLength(17)]
        public string phone1 { get; set; }

        [StringLength(17)]
        public string phone2 { get; set; }

        public int? corporatn { get; set; }

        [StringLength(2)]
        public string stateofinc { get; set; }

        [StringLength(20)]
        public string llcaih { get; set; }

        public bool internet { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        [StringLength(50)]
        public string idnumber { get; set; }

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
