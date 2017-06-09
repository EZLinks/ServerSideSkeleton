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

namespace Default
{
	[Alias("tblTicketTrans")]
    public partial class tblTicketTran 
    {
        [Required]
		[PrimaryKey]
        public Guid uidTicketTranID { get; set; }
        [Required]
        public Guid uidTicketID { get; set; }
        [Required]
        public int lngLineNumber { get; set; }
        [Required]
        public Guid uidParentTicketTranID { get; set; }
        [Required]
        public Guid uidMemberID { get; set; }
        [Required]
        public Guid uidSellableItemID { get; set; }
        [Required]
        public Guid uidBaseSellableItemID { get; set; }
        [Required]
        public string strTicketTranType { get; set; }
        [Required]
        public string strDescription { get; set; }
        [Required]
        public int lngSeatNumber { get; set; }
        [Required]
        public int lngSplitTicketNumber { get; set; }
        [Required]
        public decimal lngQtySold { get; set; }
        [Required]
        public decimal lngQtyRemovedFromInv { get; set; }
        [Required]
        public decimal curItemAmount { get; set; }
        [Required]
        public decimal curTaxIncludedPrice { get; set; }
        [Required]
        public bool blnCredit { get; set; }
        [Required]
        public bool blnDebit { get; set; }
        [Required]
        public Guid uidAcctCodeID { get; set; }
        [Required]
        public Guid uidStatCodeID { get; set; }
        [Required]
        public Guid uidInvClassID { get; set; }
        [Required]
        public decimal decCost { get; set; }
        [Required]
        public bool blnStockItem { get; set; }
        [Required]
        public Guid uidInvMenuID { get; set; }
        [Required]
        public Guid uidRegisterPrinterID { get; set; }
        [Required]
        public bool blnPrintOnReceipt { get; set; }
        [Required]
        public decimal curTaxAllocation { get; set; }
        [Required]
        public decimal curGratAllocation { get; set; }
        [Required]
        public bool blnRepeatRound { get; set; }
        [Required]
        public bool blnSeeServer { get; set; }
        [Required]
        public bool blnItemSplitBetweenTickets { get; set; }
        [Required]
        public Guid uidOriginalTicketTranID { get; set; }
        [Required]
        public string xmlCertID { get; set; }
        [Required]
        public string strETS_GiftCardNumber { get; set; }
        [Required]
        public bool blnIsTaxable { get; set; }
        [Required]
        public int lngCourse { get; set; }
        [Required]
        public bool blnCourseFired { get; set; }
        [Required]
        public int lngLP_PointsEarned { get; set; }
        [Required]
        public int lngLP_PointsRedeemed { get; set; }
        [Required]
        public string strKitType { get; set; }
        [Required]
        public int lngInvSize { get; set; }
        [Required]
        public string strSizeLabel { get; set; }
        [Required]
        public string strTenderProcedureType { get; set; }
        [Required]
        public string strReference { get; set; }
        [Required]
        public string strVerification { get; set; }
        public string strTransactionSequence { get; set; }
        [Required]
        public decimal decConversion { get; set; }
        [Required]
        public bool blnDeleted { get; set; }
        [Required]
        public bool blnWaste { get; set; }
        [Required]
        public bool blnCoverItem { get; set; }
        [Required]
        public bool blnTipAdded { get; set; }
        [Required]
        public bool blnMovedTip { get; set; }
        [Required]
        public bool blnPrintedToKitchen { get; set; }
        [Required]
        public string strPriceType { get; set; }
        [Required]
        public DateTimeOffset dtmTranDateTime { get; set; }
        [Required]
        public bool blnIsEventDetail { get; set; }
        [Required]
        public decimal lngQtyReturned { get; set; }
        [Required]
        public Guid uidFBCourseID { get; set; }
        [Required]
        public bool blnPreFired { get; set; }
    }

}
#pragma warning restore 1591
