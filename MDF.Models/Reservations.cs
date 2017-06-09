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
	[Alias("Reservations")]
    public partial class Reservation 
    {
        [AutoIncrement]
		[PrimaryKey]
        public int ReservationId { get; set; }
        [Required]
        public int CreatedFacilityId { get; set; }
        [Required]
        public int Holes { get; set; }
        [Required]
        public bool IsBookedInAdvance { get; set; }
        public string Notes { get; set; }
        [Required]
        public int TeeId { get; set; }
        public int? ReservationSourceId { get; set; }
        public int? MainReserverBookingId { get; set; }
        public Guid? LockId { get; set; }
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
