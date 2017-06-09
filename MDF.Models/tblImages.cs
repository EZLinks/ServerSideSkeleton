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
	[Alias("tblImages")]
    public partial class tblImage 
    {
        [Required]
		[PrimaryKey]
        public Guid uidImageID { get; set; }
        public byte[] imgPicture { get; set; }
        [Required]
        public string strName { get; set; }
        [Required]
        public string strOriginalFullPath { get; set; }
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
