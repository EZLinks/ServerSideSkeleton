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
	[Alias("tblDeletedTicketTrans")]
    public partial class tblDeletedTicketTran 
    {
        [Required]
        public Guid uidTicketTranID { get; set; }
        [Required]
        public Guid uidTicketID { get; set; }
        [Required]
        public Guid uidBaseSellableItemID { get; set; }
        [Required]
        public Guid uidParentTicketTranID { get; set; }
        [Required]
        public string strTicketTranType { get; set; }
        [Required]
        public decimal curItemAmount { get; set; }
        [Required]
        public decimal lngQtySold { get; set; }
        [Required]
        public bool blnWaste { get; set; }
        [Required]
        public DateTimeOffset dtmTranDateTime { get; set; }
        [Required]
        public string strKitType { get; set; }
        [Required]
        public decimal decCost { get; set; }
        [Required]
        public string strDelReason { get; set; }
    }

}
#pragma warning restore 1591
