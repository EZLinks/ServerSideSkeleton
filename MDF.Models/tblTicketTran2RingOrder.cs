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
	[Alias("tblTicketTran2RingOrder")]
    public partial class tblTicketTran2RingOrder 
    {
        [Required]
		[PrimaryKey]
        public Guid uidTicketTran2RingOrderID { get; set; }
        [Required]
        public Guid uidInitialTicketID { get; set; }
        [Required]
        public Guid uidTicketTranID { get; set; }
        [Required]
        public int lngRingOrder { get; set; }
    }

}
#pragma warning restore 1591
