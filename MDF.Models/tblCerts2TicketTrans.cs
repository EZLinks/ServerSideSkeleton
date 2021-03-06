// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;
using ServiceStack;

namespace ClubData
{
	[Alias("tblCerts2TicketTrans")]
    public partial class tblCerts2TicketTran 
    {
        [Required]
		[PrimaryKey]
        public Guid uidCert2TicketTranID { get; set; }
        [Required]
        public Guid uidTicketID { get; set; }
        [Required]
        public Guid uidTicketTranID { get; set; }
        [Required]
        public Guid uidCertID { get; set; }
        [Required]
        public Guid uidCertTranID { get; set; }
        [Required]
        public long lngCertNumber { get; set; }
        [Required]
        public string strPurchaser { get; set; }
        [Required]
        public string strReceiver { get; set; }
        [Required]
        public decimal curAmount { get; set; }
        [Required]
        public bool blnIsReload { get; set; }
    }

}
#pragma warning restore 1591
