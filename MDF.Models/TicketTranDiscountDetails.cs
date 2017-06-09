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
	[Alias("TicketTranDiscountDetails")]
    public partial class TicketTranDiscountDetail 
    {
        [Required]
        public Guid TicketID { get; set; }
        [Required]
        public Guid TicketTranID { get; set; }
        [Required]
        public Guid DiscountID { get; set; }
        [Required]
        public decimal UnroundedAmount { get; set; }
        [Required]
        public decimal RoundedAmount { get; set; }
        public Guid? DiscountTicketTranID { get; set; }
    }

}
#pragma warning restore 1591
