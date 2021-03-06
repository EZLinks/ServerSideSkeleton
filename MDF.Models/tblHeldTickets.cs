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
	[Alias("tblHeldTickets")]
    public partial class tblHeldTicket 
    {
        [Required]
		[PrimaryKey]
        public Guid uidHeldTicketID { get; set; }
        [Required]
        public Guid uidDeptID { get; set; }
        [Required]
        public DateTimeOffset dtmOpenedDate { get; set; }
        [Required]
        public bool blnGratExcluded { get; set; }
        [Required]
        public bool blnTaxExcluded { get; set; }
        [Required]
        public string strTableReferenceNumber { get; set; }
        [Required]
        public string strTaxExemptReason { get; set; }
        [Required]
        public Guid uidTicketID { get; set; }
        [Required]
        public bool blnFireCourse { get; set; }
        [Required]
        public bool blnReceiptHasBeenPrinted { get; set; }
        [Required]
        public Guid uidFB_TableID { get; set; }
        [Required]
        public string strHeldByType { get; set; }
        [Required]
        public string strOldHeldDesciption { get; set; }
        [Required]
        public int lngCovers { get; set; }
        [Required]
        public bool blnOverrideTax { get; set; }
        [Required]
        public bool blnOverrideGrat { get; set; }
        [Required]
        public string strCustomerID { get; set; }
        [Required]
        public string strSplitType { get; set; }
        [Required]
        public Guid uidSplitTicketParentID { get; set; }
        [Required]
        public int lngSplitTicketPosition { get; set; }
        [Required]
        public decimal curOverrideGratPercent { get; set; }
        [Required]
        public string strTabTranID { get; set; }
        [Required]
        public Guid uidFB_RoomID { get; set; }
        [Required]
        public Guid uidTabTenderID { get; set; }
        [Required]
        public decimal lngTabAuthorizedAmt { get; set; }
        [Required]
        public string strTabAuth { get; set; }
        [Required]
        public bool blnCoursing { get; set; }
        [Required]
        public bool blnPreFirePrinted { get; set; }
        [Required]
        public string sOrigToken { get; set; }
        [Required]
        public int lngGratCoverCount { get; set; }
        [Required]
        public string strCustomerName { get; set; }
        [Required]
        public string strCustomerCCNumber { get; set; }
    }

}
#pragma warning restore 1591
