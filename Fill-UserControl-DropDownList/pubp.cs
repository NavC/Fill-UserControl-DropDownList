namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pubp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pubp()
        {
            pubpspersons = new HashSet<pubpsperson>();
        }

        [Key]
        public int ps_id { get; set; }

        public int? conductedby_id { get; set; }

        [StringLength(80)]
        public string business_name { get; set; }

        [StringLength(2)]
        public string state_inc { get; set; }

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

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(100)]
        public string maddress1 { get; set; }

        [StringLength(100)]
        public string maddress2 { get; set; }

        [StringLength(40)]
        public string mcity { get; set; }

        [StringLength(2)]
        public string mstate { get; set; }

        [StringLength(10)]
        public string mzip { get; set; }

        [StringLength(100)]
        public string corpaddress1 { get; set; }

        [StringLength(100)]
        public string corpaddress2 { get; set; }

        [StringLength(40)]
        public string corpcity { get; set; }

        [StringLength(2)]
        public string corpstate { get; set; }

        [StringLength(10)]
        public string corpzip { get; set; }

        [StringLength(17)]
        public string workphone { get; set; }

        public int? primarysecondary { get; set; }

        [StringLength(50)]
        public string primarycounty { get; set; }

        [StringLength(20)]
        public string bond_id { get; set; }

        [StringLength(200)]
        public string bonding_company { get; set; }

        public double? amount { get; set; }

        public DateTime? filed_date { get; set; }

        public DateTime? expiration_date { get; set; }

        public DateTime? fill_dttm { get; set; }

        public bool internet { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        public DateTime? bondexpiration_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pubpsperson> pubpspersons { get; set; }
    }
}
