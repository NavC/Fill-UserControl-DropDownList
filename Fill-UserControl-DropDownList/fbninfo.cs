namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fbninfo")]
    public partial class fbninfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fbninfo()
        {
            fbnnames = new HashSet<fbnname>();
            fbnregis = new HashSet<fbnregi>();
        }

        [Key]
        public int fbnid { get; set; }

        [StringLength(70)]
        public string address1 { get; set; }

        [StringLength(70)]
        public string address2 { get; set; }

        [StringLength(70)]
        public string maddress1 { get; set; }

        [StringLength(70)]
        public string maddress2 { get; set; }

        [StringLength(17)]
        public string phone1 { get; set; }

        public int filetype { get; set; }

        [StringLength(30)]
        public string othertype { get; set; }

        public DateTime? filestamp { get; set; }

        public int? fnameqty { get; set; }

        public int? registqty { get; set; }

        public double? fee { get; set; }

        public int? renewnot { get; set; }

        public DateTime? fill_dttm { get; set; }

        public bool internet { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        public bool notbegun { get; set; }

        public bool issameaddr { get; set; }

        public byte commdate_month { get; set; }

        public byte commdate_day { get; set; }

        public short commdate_year { get; set; }

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

        [StringLength(10)]
        public string agentphone { get; set; }

        [StringLength(40)]
        public string county { get; set; }

        public bool renewal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fbnname> fbnnames { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fbnregi> fbnregis { get; set; }
    }
}
