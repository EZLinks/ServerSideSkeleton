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
	[Alias("SeasonSchedules")]
    public partial class SeasonSchedule 
    {
        public int? Facility_Id { get; set; }
        [AutoIncrement]
		[PrimaryKey]
        public int Id { get; set; }
        public int? Season_Id { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }

}
#pragma warning restore 1591
