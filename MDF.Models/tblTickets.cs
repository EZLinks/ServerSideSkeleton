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
	[Alias("tblTickets")]
    public partial class tblTicket 
    {
        [Required]
		[PrimaryKey]
        public Guid uidTicketID { get; set; }
        [Required]
        public int lngTicketNumber { get; set; }
        [Required]
        public Guid uidZeeID { get; set; }
        [Required]
        public Guid uidMemberID { get; set; }
        [Required]
        public Guid uidEventID { get; set; }
        [Required]
        public string strTicketType { get; set; }
        [Required]
        public Guid uidRegisterID { get; set; }
        [Required]
        public string strZipCode { get; set; }
        [Required]
        public int lngCover { get; set; }
        [Required]
        public bool blnVoided { get; set; }
        [Required]
        public Guid uidEmplID { get; set; }
        [Required]
        public DateTimeOffset dtmOpenedDate { get; set; }
        [Required]
        public bool blnPosted { get; set; }
        [Required]
        public bool blnClosed { get; set; }
        [Required]
        public Guid uidBatchID { get; set; }
        [Required]
        public string txtReceiptPrinted { get; set; }
        [Required]
        public DateTimeOffset dtmPostedTime { get; set; }
        public DateTimeOffset? dtmBatchPostDate { get; set; }
        public string strReciprocalName { get; set; }
        [Required]
        public bool blnCanceled { get; set; }
        [Required]
        public string txtPrintedReceiptText { get; set; }
        [Required]
        public Guid uidTicketDeptID { get; set; }
    }

}
#pragma warning restore 1591
