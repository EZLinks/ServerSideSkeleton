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
	[Alias("Facilities")]
    public partial class Facility 
    {
        [AutoIncrement]
		[PrimaryKey]
        public int Id { get; set; }
        [Required]
        public string Abbreviation { get; set; }
        [Required]
        public Guid DepartmentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid QuickPlayerID { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public DateTimeOffset Created { get; set; }
        [Required]
        public Guid CreatedByID { get; set; }
        [Required]
        public DateTimeOffset LastUpdated { get; set; }
        [Required]
        public Guid LastUpdatedByID { get; set; }
        public string CloudFriendlyName { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public int LockTimeout { get; set; }
    }

}
#pragma warning restore 1591
