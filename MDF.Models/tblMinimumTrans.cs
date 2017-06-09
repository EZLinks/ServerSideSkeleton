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
	[Alias("tblMinimumTrans")]
    public partial class tblMinimumTran 
    {
        [Required]
		[PrimaryKey]
        public Guid uidMinimumTranID { get; set; }
        [Required]
        public Guid uidMinimumID { get; set; }
        [Required]
        public Guid uidMemberID { get; set; }
        public Guid? uidTicketID { get; set; }
        [Required]
        public decimal curMinimumAmount { get; set; }
        [Required]
        public Guid uidMemberPurchaseId { get; set; }
        [Required]
        public DateTime dtmMinTranDate { get; set; }
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
