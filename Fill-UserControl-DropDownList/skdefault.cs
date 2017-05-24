namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("skdefault")]
    public partial class skdefault
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string officename { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string location { get; set; }

        [StringLength(100)]
        public string clerkrecorder { get; set; }

        [StringLength(60)]
        public string title { get; set; }

        [StringLength(40)]
        public string address { get; set; }

        [StringLength(40)]
        public string citystzip { get; set; }

        [StringLength(40)]
        public string county { get; set; }

        [StringLength(70)]
        public string mailaddr { get; set; }

        [StringLength(70)]
        public string mailaddr2 { get; set; }

        [StringLength(17)]
        public string phone { get; set; }

        [StringLength(17)]
        public string fax { get; set; }

        [StringLength(10)]
        public string fromhour { get; set; }

        [StringLength(10)]
        public string tohour { get; set; }

        [Key]
        [Column(Order = 2)]
        public double publicfee { get; set; }

        [Key]
        [Column(Order = 3)]
        public double confidfee { get; set; }

        [Key]
        [Column(Order = 4)]
        public double certifcopyfee { get; set; }

        [Key]
        [Column(Order = 5)]
        public double ceremonyfee { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool feesdialog { get; set; }

        [Key]
        [Column(Order = 7)]
        public double fbnfee { get; set; }

        [Key]
        [Column(Order = 8)]
        public double addregfee { get; set; }

        [Key]
        [Column(Order = 9)]
        public double addfbnfee { get; set; }

        public double? fishadminfee { get; set; }

        [Key]
        [Column(Order = 10)]
        public double fbnrenewfee { get; set; }

        [Key]
        [Column(Order = 11)]
        public double renewyear { get; set; }

        [Key]
        [Column(Order = 12)]
        public double renewdays { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fbnautorenew { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fbninactdays { get; set; }

        [StringLength(40)]
        public string fgclerknm { get; set; }

        [StringLength(40)]
        public string fgclerkttl { get; set; }

        [Key]
        [Column(Order = 15)]
        public double notexpyear { get; set; }

        public double? bondamt { get; set; }

        [StringLength(150)]
        public string not_rtl_path { get; set; }

        [StringLength(70)]
        public string altadd1 { get; set; }

        [StringLength(70)]
        public string altadd2 { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool printalt { get; set; }

        [StringLength(100)]
        public string noathrev { get; set; }

        [Key]
        [Column(Order = 17)]
        public double fbnproof { get; set; }

        [Key]
        [Column(Order = 18)]
        public double fbnlastproof { get; set; }

        [Key]
        [Column(Order = 19)]
        public double mrgrretday { get; set; }

        [Key]
        [Column(Order = 20)]
        public double mrgrlicexp { get; set; }

        [Key]
        [Column(Order = 21)]
        public double mrgcretday { get; set; }

        [Key]
        [Column(Order = 22)]
        public double mrgclicexp { get; set; }

        [Key]
        [Column(Order = 23)]
        public double mrgpretday { get; set; }

        [Key]
        [Column(Order = 24)]
        public double mrgplicexp { get; set; }

        [Key]
        [Column(Order = 25)]
        public double mrgexpnot { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool mrgshowrecname { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool mrgoverrideperssolem { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mrgnotexpnot { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool fishprtnot { get; set; }

        [Key]
        [Column(Order = 30)]
        public double maxfbnfetch { get; set; }

        [Key]
        [Column(Order = 31)]
        public double minfbnfetch { get; set; }

        [Key]
        [Column(Order = 32)]
        public double mrgbretday { get; set; }

        [Key]
        [Column(Order = 33)]
        public double mrgblicexp { get; set; }

        [Key]
        [Column(Order = 34)]
        public double maxfetch { get; set; }

        [Key]
        [Column(Order = 35)]
        public double minfetch { get; set; }

        [Key]
        [Column(Order = 36)]
        public double maxidnfetch { get; set; }

        [Key]
        [Column(Order = 37)]
        public double minidnfetch { get; set; }

        [StringLength(40)]
        public string state { get; set; }

        [Key]
        [Column(Order = 38)]
        public double psfilreg { get; set; }

        [Key]
        [Column(Order = 39)]
        public double psfngcard { get; set; }

        [Key]
        [Column(Order = 40)]
        public double psrecordfee { get; set; }

        [Key]
        [Column(Order = 41)]
        public double psaddpage { get; set; }

        [Key]
        [Column(Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int psrenewy { get; set; }

        [Key]
        [Column(Order = 43)]
        public double psbondamount { get; set; }

        public int? pstempcardexpdays { get; set; }

        public int? psrenewnotdays { get; set; }

        [Key]
        [Column(Order = 44)]
        public double ppcfilreg { get; set; }

        [Key]
        [Column(Order = 45)]
        public double ppcrecordfee { get; set; }

        [Key]
        [Column(Order = 46)]
        public double ppcaddpage { get; set; }

        [Key]
        [Column(Order = 47)]
        public double ppcifregps { get; set; }

        [Key]
        [Column(Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ppcrenewy { get; set; }

        [Key]
        [Column(Order = 49)]
        public double ppcbondamount { get; set; }

        public int? ppcrenewnotdays { get; set; }

        [Key]
        [Column(Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ppcnotrenewnotdays { get; set; }

        [StringLength(100)]
        public string imgreppath { get; set; }

        [StringLength(150)]
        public string usersignpath { get; set; }

        [StringLength(150)]
        public string npsettingspath { get; set; }

        [StringLength(150)]
        public string helppath { get; set; }

        [Key]
        [Column(Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ldarenewy { get; set; }

        public double? ldafee { get; set; }

        public double? ldafilreg { get; set; }

        public double? ldafilbond { get; set; }

        public double? ldarecbond { get; set; }

        public double? ldaaddpage { get; set; }

        public int? ldaaddcard { get; set; }

        public int? ldarenewnotdays { get; set; }

        public double? ldabondamount { get; set; }

        [Key]
        [Column(Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int udarenewy { get; set; }

        public double? udafee { get; set; }

        public double? udafilreg { get; set; }

        public double? udafilbond { get; set; }

        public double? udarecbond { get; set; }

        public double? udaaddpage { get; set; }

        public double? udaaddcard { get; set; }

        public int? udarenewnotdays { get; set; }

        public double? udabondamount { get; set; }

        public double? poaexpyear { get; set; }

        [Column(TypeName = "text")]
        public string nightproc_help { get; set; }

        [StringLength(3)]
        public string defphonepref { get; set; }

        [StringLength(40)]
        public string defcity { get; set; }

        [StringLength(2)]
        public string defstate { get; set; }

        [Key]
        [Column(Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int appcase { get; set; }

        [Key]
        [Column(Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fbncase { get; set; }

        [Key]
        [Column(Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mrgcase { get; set; }

        [Key]
        [Column(Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pscase { get; set; }

        [Key]
        [Column(Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ldacase { get; set; }

        [Key]
        [Column(Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int udacase { get; set; }

        [Key]
        [Column(Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ppccase { get; set; }

        [Key]
        [Column(Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int poacase { get; set; }

        [Key]
        [Column(Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int notpubcase { get; set; }

        [Key]
        [Column(Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int eircase { get; set; }

        [Key]
        [Column(Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int oathscase { get; set; }

        [Key]
        [Column(Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int passportscase { get; set; }

        [Key]
        [Column(Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int autopsycase { get; set; }

        [Key]
        [Column(Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pacase { get; set; }

        [Key]
        [Column(Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int publictype { get; set; }

        [Key]
        [Column(Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int confidtype { get; set; }

        [Key]
        [Column(Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int declaredtype { get; set; }

        [Key]
        [Column(Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nondenomtype { get; set; }

        [Key]
        [Column(Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int incarctype { get; set; }

        public double? fbnmaxrenewprd { get; set; }

        [Key]
        [Column(Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int udausebond { get; set; }

        [Key]
        [Column(Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ldausebond { get; set; }

        [Key]
        [Column(Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ppcusebond { get; set; }

        [Key]
        [Column(Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int psusebond { get; set; }

        [StringLength(40)]
        public string defsolemtitle { get; set; }

        [Key]
        [Column(Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int notpubusebond { get; set; }

        [Key]
        [Column(Order = 77)]
        public double notminrenewprd { get; set; }

        [Key]
        [Column(Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int showfbnstmt { get; set; }

        [Key]
        [Column(Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ldaactivereg { get; set; }

        [Key]
        [Column(Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int udaactivereg { get; set; }

        [Key]
        [Column(Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ppcactivereg { get; set; }

        [Key]
        [Column(Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int psactivereg { get; set; }

        [Key]
        [Column(Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int usecashmrglicnum { get; set; }

        [Key]
        [Column(Order = 84)]
        public double notnameactproof { get; set; }

        [Key]
        [Column(Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int notrenewnotdays { get; set; }

        [Key]
        [Column(Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int npdayskeep { get; set; }

        [Key]
        [Column(Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int showpubdates { get; set; }

        [Key]
        [Column(Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int validpubdates { get; set; }

        [Key]
        [Column(Order = 89, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp_column { get; set; }

        [Key]
        [Column(Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ldamaxbondrn { get; set; }

        [Key]
        [Column(Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int udamaxbondrn { get; set; }

        [Key]
        [Column(Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ppcmaxbondrn { get; set; }

        [Key]
        [Column(Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int psmaxbondrn { get; set; }

        [Key]
        [Column(Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ldapubpurgemode { get; set; }

        [Key]
        [Column(Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ldapubpurgedays { get; set; }

        [Key]
        [Column(Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int udapubpurgemode { get; set; }

        [Key]
        [Column(Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int udapubpurgedays { get; set; }

        [Key]
        [Column(Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pspubpurgemode { get; set; }

        [Key]
        [Column(Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pspubpurgedays { get; set; }

        [Key]
        [Column(Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ppcpubpurgemode { get; set; }

        [Key]
        [Column(Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ppcpubpurgedays { get; set; }

        [Key]
        [Column(Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nppubpurgemode { get; set; }

        [Key]
        [Column(Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nppubpurgedays { get; set; }

        [Key]
        [Column(Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fbnpubpurgemode { get; set; }

        [Key]
        [Column(Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fbnpubpurgedays { get; set; }

        [Key]
        [Column(Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nmlpubpurgemode { get; set; }

        [Key]
        [Column(Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nmlpubpurgedays { get; set; }

        [Key]
        [Column(Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mrgpubpurgemode { get; set; }

        [Key]
        [Column(Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mrgpubpurgedays { get; set; }

        [Key]
        [Column(Order = 110)]
        public bool mrgsetregdt { get; set; }

        [Key]
        [Column(Order = 111)]
        public bool mrgregdtenable { get; set; }

        [Key]
        [Column(Order = 112)]
        public bool mrgchangemln { get; set; }

        [Key]
        [Column(Order = 113)]
        public bool mrgimportmrgdate { get; set; }

        [StringLength(70)]
        public string mrgmisctitle1 { get; set; }

        [StringLength(70)]
        public string mrgmisctitle2 { get; set; }

        [StringLength(40)]
        public string mrgmiscaddress { get; set; }

        [StringLength(20)]
        public string mrgmisccity { get; set; }

        [StringLength(2)]
        public string mrgmiscstate { get; set; }

        [StringLength(9)]
        public string mrgmisczip { get; set; }

        [StringLength(10)]
        public string mrgmiscphone { get; set; }

        [Key]
        [Column(Order = 114)]
        public bool isfraudgr { get; set; }

        [Key]
        [Column(Order = 115)]
        public bool isfraudbr { get; set; }

        [Key]
        [Column(Order = 116)]
        public bool fraudgrf { get; set; }

        [Key]
        [Column(Order = 117)]
        public bool fraudgrm { get; set; }

        [Key]
        [Column(Order = 118)]
        public bool fraudgrl { get; set; }

        [Key]
        [Column(Order = 119)]
        public bool fraudbrf { get; set; }

        [Key]
        [Column(Order = 120)]
        public bool fraudbrm { get; set; }

        [Key]
        [Column(Order = 121)]
        public bool fraudbrl { get; set; }

        [Key]
        [Column(Order = 122)]
        public bool changepwd { get; set; }

        [Key]
        [Column(Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pwdexpdays { get; set; }

        [Key]
        [Column(Order = 124)]
        public bool npallowchangestate { get; set; }

        [Key]
        [Column(Order = 125)]
        public double incarcfee { get; set; }

        [Key]
        [Column(Order = 126)]
        public bool prlocalregnumber { get; set; }

        [Key]
        [Column(Order = 127)]
        public bool prregdate { get; set; }

        [Key]
        [Column(Order = 128)]
        public byte sentletterkeep { get; set; }

        [StringLength(70)]
        public string recorderaddr1 { get; set; }

        [StringLength(70)]
        public string recorderaddr2 { get; set; }

        [StringLength(70)]
        public string clerkaddr1 { get; set; }

        [StringLength(70)]
        public string clerkaddr2 { get; set; }

        [StringLength(30)]
        public string mrgduplicate { get; set; }

        [Column(TypeName = "text")]
        public string expletnote { get; set; }

        [StringLength(150)]
        public string expletbatchpath { get; set; }

        [Key]
        [Column(Order = 129)]
        public double incarcpubfee { get; set; }

        [Key]
        [Column(Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int incarcpubtype { get; set; }

        [Key]
        [Column(Order = 131)]
        public byte mrgimportorder { get; set; }

        [Key]
        [Column(Order = 132)]
        public byte nmlimportorder { get; set; }

        [Key]
        [Column(Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int passpubpurgemode { get; set; }

        [Key]
        [Column(Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int passpubpurgedays { get; set; }

        [Key]
        [Column(Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int passkeepdays { get; set; }

        [Key]
        [Column(Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int passtranspurgeyears { get; set; }

        [Key]
        [Column(Order = 137)]
        public double passexpfee { get; set; }

        [Key]
        [Column(Order = 138)]
        public double passexecfee { get; set; }

        [Key]
        [Column(Order = 139)]
        public double passbookfee { get; set; }

        [Key]
        [Column(Order = 140)]
        public double passbookminorfee { get; set; }

        [Key]
        [Column(Order = 141)]
        public double passcardfee { get; set; }

        [Key]
        [Column(Order = 142)]
        public double passcardminorfee { get; set; }

        [StringLength(12)]
        public string passfacilitynumber { get; set; }

        [Key]
        [Column(Order = 143)]
        public bool passshowssn { get; set; }

        [Key]
        [Column(Order = 144)]
        public bool passisduplex { get; set; }

        [Key]
        [Column(Order = 145)]
        public byte acceptapp { get; set; }

        public DateTime? mrgshownewnamesdt { get; set; }

        public DateTime? mrghideoccdt { get; set; }

        public DateTime? mrghidemaidendt { get; set; }

        [Key]
        [Column(Order = 146)]
        public bool mrgshowregdate { get; set; }

        public DateTime? mrgshowgroombrideopt { get; set; }

        [Key]
        [Column(Order = 147)]
        public bool mrgcountrydesc { get; set; }

        [Key]
        [Column(Order = 148)]
        public byte mrgperiodmin { get; set; }

        [Key]
        [Column(Order = 149)]
        public bool mrgshowperftime { get; set; }

        [StringLength(10)]
        public string fbnletterphone { get; set; }

        [StringLength(70)]
        public string courtaddline1 { get; set; }

        [StringLength(70)]
        public string courtaddline2 { get; set; }

        [StringLength(70)]
        public string courtaddline3 { get; set; }

        [StringLength(40)]
        public string courtname { get; set; }

        [StringLength(10)]
        public string notpubdivphone { get; set; }

        [StringLength(100)]
        public string website { get; set; }

        [Key]
        [Column(Order = 150)]
        public bool simplelogevent { get; set; }

        public DateTime? newmlstartdate { get; set; }

        [Key]
        [Column(Order = 151)]
        public byte mrgcutoffday { get; set; }

        [StringLength(10)]
        public string mrgphone { get; set; }

        public bool? mrglimitnext { get; set; }

        [Key]
        [Column(Order = 152)]
        public bool fbnshownotbegun { get; set; }

        [Key]
        [Column(Order = 153)]
        public bool ispartialcommdate { get; set; }

        [Key]
        [Column(Order = 154)]
        public bool fbnprintaffidavit { get; set; }

        [Key]
        [Column(Order = 155)]
        public bool fbnprintprompt { get; set; }

        [Key]
        [Column(Order = 156)]
        public bool fbnshowagentinfo { get; set; }
    }
}
