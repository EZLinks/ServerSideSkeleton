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
	[Alias("tblMemberBillingProperties")]
    public partial class tblMemberBillingProperty 
    {
        [Required]
		[PrimaryKey]
        public Guid uidMemberBillingPropertyID { get; set; }
        [Required]
        public Guid uidMemberID { get; set; }
        [Required]
        public decimal decFinanceRate { get; set; }
        [Required]
        public bool blnReciprocal { get; set; }
        [Required]
        public decimal curCreditLimit { get; set; }
        [Required]
        public bool blnSubtotalExtensionsOnStatement { get; set; }
        [Required]
        public int lngBillingCycleStartDay { get; set; }
        [Required]
        public string strStatementType { get; set; }
        [Required]
        public bool blnViewStatementOnWeb { get; set; }
        [Required]
        public bool blnChargeEZPay { get; set; }
        public string strCreditCardNumber { get; set; }
        [Required]
        public string strCreditCardExp { get; set; }
        [Required]
        public Guid uidTenderID { get; set; }
        [Required]
        public Guid uidAVSAddressID { get; set; }
        [Required]
        public Guid uidCC_ClientID { get; set; }
        [Required]
        public string strEZPayType { get; set; }
        public Guid? uidEZPayProcessorTokenID { get; set; }
        public DateTime? Created { get; set; }
        public Guid? CreatedByID { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Guid? LastUpdatedByID { get; set; }
    }

}
#pragma warning restore 1591
