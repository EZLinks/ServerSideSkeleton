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
	[Alias("tblTenders")]
    public partial class tblTender 
    {
        [Required]
		[PrimaryKey]
        public Guid uidTenderID { get; set; }
        [Required]
        public Guid uidSellableItemID { get; set; }
        [Required]
        public bool blnPopCashDrawer { get; set; }
        [Required]
        public string strProcedureType { get; set; }
        [Required]
        public bool blnAddSignatureLineOnReceipt { get; set; }
        [Required]
        public bool blnAddTipLineOnReceipt { get; set; }
        [Required]
        public string strCC_StartCharacter { get; set; }
        [Required]
        public Guid uidMemberTypeID { get; set; }
        [Required]
        public Guid uidCertCodeID { get; set; }
        [Required]
        public string strHotelDirectory { get; set; }
        [Required]
        public int lngHotelTimeout { get; set; }
        [Required]
        public decimal decForeignCurrencyConversion { get; set; }
        [Required]
        public string strForeignCurrencyAbbreviation { get; set; }
        [Required]
        public Guid uidForeignCurrencyTenderID { get; set; }
        [Required]
        public bool blnShowConvertedTotalAtRegister { get; set; }
        [Required]
        public bool blnShowConvertedTotalOnReceipt { get; set; }
        [Required]
        public bool blnAllowChange { get; set; }
        public string strRevenueCenterNumber { get; set; }
        public string strCurrentPaymentNumber { get; set; }
        public bool? blnSplitRevenueToPMS { get; set; }
        [Required]
        public bool blnDeleted { get; set; }
        public bool? blnPostTOARAccounts { get; set; }
        [Required]
        public bool blnDoNotRequireCheckNumber { get; set; }
        [Required]
        public decimal decSignatureThresholdAmount { get; set; }
        [Required]
        public DateTimeOffset Created { get; set; }
        [Required]
        public Guid CreatedByID { get; set; }
        [Required]
        public DateTimeOffset LastUpdated { get; set; }
        [Required]
        public Guid LastUpdatedByID { get; set; }
    }

}
#pragma warning restore 1591
