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
	[Alias("ConditionReservationDays")]
    public partial class ConditionReservationDay 
    {
        [Required]
		[PrimaryKey]
        public Guid Id { get; set; }
        [Required]
        public int State { get; set; }
    }

}
#pragma warning restore 1591
