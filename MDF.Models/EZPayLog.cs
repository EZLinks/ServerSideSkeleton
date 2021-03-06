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
	[Alias("EZPayLog")]
    public partial class EZPayLog 
    {
        [Required]
		[PrimaryKey]
        public Guid EZPayLogID { get; set; }
        [Required]
        public DateTimeOffset ProcessedOn { get; set; }
        [Required]
        public Guid ProcessedByID { get; set; }
        [Required]
        public Guid MemberID { get; set; }
        [Required]
        public Guid MemberBalanceID { get; set; }
        [Required]
        public decimal StatementBalance { get; set; }
        [Required]
        public DateTime StatementDate { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string MaskedNumber { get; set; }
        public string ProcessorTokenType { get; set; }
        public string CreditCardType { get; set; }
        public string ExpirationDate { get; set; }
        public string Merchant { get; set; }
        [Required]
        public string EZPayMode { get; set; }
        [Required]
        public bool IsApproved { get; set; }
        [Required]
        public bool IsSuccessful { get; set; }
        public string ApprovalCode { get; set; }
        public string TransactionID { get; set; }
        public string AccountID { get; set; }
        public string SessionID { get; set; }
        public Guid? TicketID { get; set; }
        public Guid? TicketTranID { get; set; }
        public string Message { get; set; }
    }

}
#pragma warning restore 1591
