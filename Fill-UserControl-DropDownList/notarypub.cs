namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("notarypub")]
    public partial class notarypub
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int notary_id { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(30)]
        public string firstname { get; set; }

        [StringLength(30)]
        public string middlename { get; set; }

        [StringLength(80)]
        public string business_name { get; set; }

        [StringLength(9)]
        public string commission_number { get; set; }

        public DateTime? commission_date { get; set; }

        public DateTime? expiration_date { get; set; }

        [StringLength(60)]
        public string address1 { get; set; }

        [StringLength(60)]
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

        [StringLength(20)]
        public string bond_id { get; set; }

        [StringLength(200)]
        public string bonding_company { get; set; }

        public double? amount { get; set; }

        public DateTime? fill_dttm { get; set; }

        public bool internet { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }
    }
}
