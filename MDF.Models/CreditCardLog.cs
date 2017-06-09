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
	[Alias("CreditCardLog")]
    public partial class CreditCardLog 
    {
        [Required]
		[PrimaryKey]
        public Guid LogID { get; set; }
        [Required]
        public DateTimeOffset LogTime { get; set; }
        [Required]
        public int LogType { get; set; }
        [Required]
        public string ProcessorType { get; set; }
        [Required]
        public Guid DepartmentID { get; set; }
        public Guid? CCTranID { get; set; }
        public Guid? SessionID { get; set; }
        public Guid? TicketID { get; set; }
        public string TranSequenceNumber { get; set; }
        [Required]
        public string Notes { get; set; }
    }

}
#pragma warning restore 1591
