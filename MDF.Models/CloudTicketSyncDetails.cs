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
	[Alias("CloudTicketSyncDetails")]
    public partial class CloudTicketSyncDetail 
    {
        [Required]
		[PrimaryKey]
        public Guid CloudTicketSyncDetailID { get; set; }
        [Required]
        public Guid CloudTicketSyncBatchID { get; set; }
        [Required]
        public Guid ConsoleTicketID { get; set; }
        [Required]
        public int ConsoleTicketNumber { get; set; }
        [Required]
        public int ConsoleZeeNumber { get; set; }
        [Required]
        public Guid CloudTicketID { get; set; }
        [Required]
        public int CloudTicketNumber { get; set; }
        [Required]
        public int CloudZeeNumber { get; set; }
    }

}
#pragma warning restore 1591
