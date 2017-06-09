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
	[Alias("ScheduleItems")]
    public partial class ScheduleItem 
    {
        [Required]
        public bool Def18 { get; set; }
        [Required]
        public bool Def3 { get; set; }
        [Required]
        public bool Def6 { get; set; }
        [Required]
        public bool Def9 { get; set; }
        public decimal? SchedulePrice { get; set; }
        [Required]
        public Guid ItemId { get; set; }
        [Required]
        public int PlayerTypeId { get; set; }
        [AutoIncrement]
		[PrimaryKey]
        public int id { get; set; }
        public int? FeeSchedule_Id { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }

}
#pragma warning restore 1591