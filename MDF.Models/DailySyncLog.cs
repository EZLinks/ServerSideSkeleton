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
	[Alias("DailySyncLog")]
    public partial class DailySyncLog 
    {
        [Required]
		[PrimaryKey]
        public Guid ID { get; set; }
        [Required]
        public Guid DailyCloseID { get; set; }
        [Required]
        public Guid TrackingID { get; set; }
        public string Message { get; set; }
        [Required]
        public DateTimeOffset Modified { get; set; }
    }

}
#pragma warning restore 1591
