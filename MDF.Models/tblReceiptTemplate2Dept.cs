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
	[Alias("tblReceiptTemplate2Dept")]
    public partial class tblReceiptTemplate2Dept 
    {
        [Required]
		[PrimaryKey]
        public Guid uidReceiptTemplate2Dept { get; set; }
        [Required]
        public Guid uidReceiptTemplateID { get; set; }
        [Required]
        public Guid uidDeptID { get; set; }
        [Required]
        public string strTemplatePrinterType { get; set; }
        [Required]
        public int lngOrder { get; set; }
    }

}
#pragma warning restore 1591
