namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mrg")]
    public partial class mrg
    {
        [Key]
        [StringLength(25)]
        public string countid { get; set; }

        [StringLength(90)]
        public string notary { get; set; }

        [StringLength(13)]
        public string notaryID { get; set; }

        public DateTime? issuedate { get; set; }

        public int mtype { get; set; }

        [StringLength(50)]
        public string hfirst { get; set; }

        [StringLength(50)]
        public string hmiddle { get; set; }

        [StringLength(50)]
        public string hlast { get; set; }

        [StringLength(50)]
        public string hclast { get; set; }

        public DateTime? hdob { get; set; }

        [StringLength(100)]
        public string hstate { get; set; }

        public byte? hnoprevmrg { get; set; }

        public byte? hmrgend { get; set; }

        public byte hdtmmrgend { get; set; }

        public byte hdtdmrgend { get; set; }

        public short hdtymrgend { get; set; }

        [StringLength(100)]
        public string hoccup { get; set; }

        [StringLength(100)]
        public string hindustry { get; set; }

        public byte? heducation { get; set; }

        [StringLength(70)]
        public string hfathname { get; set; }

        [StringLength(100)]
        public string hbirthst { get; set; }

        [StringLength(70)]
        public string hmothmdnnm { get; set; }

        [StringLength(100)]
        public string hmothbirth { get; set; }

        [StringLength(50)]
        public string hdrivlcn { get; set; }

        [StringLength(2)]
        public string hdrvexpm { get; set; }

        [StringLength(4)]
        public string hdrvexpy { get; set; }

        [StringLength(50)]
        public string wfirst { get; set; }

        [StringLength(50)]
        public string wmiddle { get; set; }

        [StringLength(50)]
        public string wlast { get; set; }

        [StringLength(50)]
        public string wclast { get; set; }

        [StringLength(40)]
        public string wmaiden { get; set; }

        public DateTime? wdob { get; set; }

        [StringLength(100)]
        public string wstate { get; set; }

        public byte? wnoprevmrg { get; set; }

        public byte? wmrgend { get; set; }

        public byte wdtmmrgend { get; set; }

        public byte wdtdmrgend { get; set; }

        public short wdtymrgend { get; set; }

        [StringLength(100)]
        public string woccup { get; set; }

        [StringLength(100)]
        public string windustry { get; set; }

        public byte? weducation { get; set; }

        [StringLength(70)]
        public string wfathname { get; set; }

        [StringLength(100)]
        public string wbirthst { get; set; }

        [StringLength(70)]
        public string wmothmdnnm { get; set; }

        [StringLength(100)]
        public string wmothbirth { get; set; }

        [StringLength(50)]
        public string wdrivlcn { get; set; }

        [StringLength(2)]
        public string wdrvexpm { get; set; }

        [StringLength(4)]
        public string wdrvexpy { get; set; }

        [StringLength(200)]
        public string haddress { get; set; }

        [StringLength(25)]
        public string hcity { get; set; }

        [StringLength(10)]
        public string hzip { get; set; }

        [StringLength(15)]
        public string hcounty { get; set; }

        [StringLength(100)]
        public string hstateres { get; set; }

        [StringLength(10)]
        public string hmdayphone { get; set; }

        [StringLength(200)]
        public string waddress { get; set; }

        [StringLength(25)]
        public string wcity { get; set; }

        [StringLength(10)]
        public string wzip { get; set; }

        [StringLength(15)]
        public string wcounty { get; set; }

        [StringLength(100)]
        public string wstateres { get; set; }

        [StringLength(10)]
        public string hmdayphone2 { get; set; }

        [StringLength(200)]
        public string hmaddress { get; set; }

        [StringLength(25)]
        public string hmcity { get; set; }

        [StringLength(10)]
        public string hmzip { get; set; }

        [StringLength(15)]
        public string hmcounty { get; set; }

        [StringLength(100)]
        public string hmstateres { get; set; }

        [StringLength(200)]
        public string wmaddress { get; set; }

        [StringLength(25)]
        public string wmcity { get; set; }

        [StringLength(10)]
        public string wmzip { get; set; }

        [StringLength(15)]
        public string wmcounty { get; set; }

        [StringLength(100)]
        public string wmstateres { get; set; }

        [StringLength(90)]
        public string witname1 { get; set; }

        [StringLength(200)]
        public string witaddr1 { get; set; }

        [StringLength(40)]
        public string witstzip1 { get; set; }

        [StringLength(90)]
        public string witname2 { get; set; }

        [StringLength(200)]
        public string witaddr2 { get; set; }

        [StringLength(40)]
        public string witstzip2 { get; set; }

        [StringLength(40)]
        public string solemdenom { get; set; }

        [StringLength(40)]
        public string solemtitle { get; set; }

        [StringLength(90)]
        public string solemname { get; set; }

        [StringLength(250)]
        public string solemaddr { get; set; }

        [StringLength(10)]
        public string solemzip { get; set; }

        public DateTime? mrgperfdt { get; set; }

        [StringLength(30)]
        public string mrgperfcity { get; set; }

        [StringLength(30)]
        public string mrgperfcounty { get; set; }

        public bool internet { get; set; }

        public bool to_import { get; set; }

        public DateTime? fill_dttm { get; set; }

        public bool activelic { get; set; }

        [Column("void")]
        public bool _void { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        [StringLength(50)]
        public string hnewmiddle { get; set; }

        [StringLength(90)]
        public string hnewlast { get; set; }

        [StringLength(50)]
        public string wnewmiddle { get; set; }

        [StringLength(90)]
        public string wnewlast { get; set; }

        public byte hgroombride { get; set; }

        public byte wgroombride { get; set; }
    }
}
