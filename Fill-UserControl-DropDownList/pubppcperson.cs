namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pubppcperson")]
    public partial class pubppcperson
    {
        [Key]
        public int ppcperson_id { get; set; }

        public int? ppc_id { get; set; }

        public int? persontype_id { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(30)]
        public string firstname { get; set; }

        [StringLength(30)]
        public string middlename { get; set; }

        [StringLength(100)]
        public string address1 { get; set; }

        [StringLength(100)]
        public string address2 { get; set; }

        [StringLength(40)]
        public string city { get; set; }

        [StringLength(2)]
        public string state { get; set; }

        [StringLength(10)]
        public string zip { get; set; }

        [StringLength(17)]
        public string homephone { get; set; }

        [StringLength(17)]
        public string workphone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public DateTime? birth_date { get; set; }

        [StringLength(40)]
        public string jobtitle { get; set; }

        public DateTime? executed_date { get; set; }

        [StringLength(40)]
        public string executed_place { get; set; }

        public byte? sex { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        public virtual pubppc pubppc { get; set; }
    }
}
