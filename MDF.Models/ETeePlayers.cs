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
	[Alias("ETeePlayers")]
    public partial class ETeePlayer 
    {
        [Required]
        public int TeeTimeId { get; set; }
        [Required]
        public Guid TicketTranId { get; set; }
        [Required]
        public Guid TicketId { get; set; }
        public int? CourseId { get; set; }
        public int? CheckinId { get; set; }
        [Required]
        public DateTime TeeTime { get; set; }
        [Required]
        public string Currency { get; set; }
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        [Required]
        public decimal GreenFee { get; set; }
        [Required]
        public decimal CartFee { get; set; }
        public string Type { get; set; }
    }

}
#pragma warning restore 1591
