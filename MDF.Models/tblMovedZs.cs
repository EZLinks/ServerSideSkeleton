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
	[Alias("tblMovedZs")]
    public partial class tblMovedZ 
    {
        [Required]
		[PrimaryKey]
        public Guid uidMovedZID { get; set; }
        [Required]
        public Guid uidNewDailyCloseID { get; set; }
        [Required]
        public int lngNewZNumber { get; set; }
        [Required]
        public Guid uidOldDailyCloseID { get; set; }
        [Required]
        public int lngOldZNumber { get; set; }
        [Required]
        public Guid uidEmplID { get; set; }
        [Required]
        public DateTimeOffset dtmMoveDateTime { get; set; }
        [Required]
        public string strComment { get; set; }
    }

}
#pragma warning restore 1591