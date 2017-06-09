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
	[Alias("tblInvMenus")]
    public partial class tblInvMenu 
    {
        [Required]
		[PrimaryKey]
        public Guid uidInvMenuID { get; set; }
        [Required]
        public Guid uidDeptID { get; set; }
        [Required]
        public string strName { get; set; }
        [Required]
        public DateTime dtmBeginDate { get; set; }
        [Required]
        public DateTime dtmEndDate { get; set; }
        [Required]
        public int lngBeginTime { get; set; }
        [Required]
        public int lngEndTime { get; set; }
        [Required]
        public bool blnQuickSaleMenu { get; set; }
        [Required]
        public bool blnAddToCovers { get; set; }
        [Required]
        public bool blnSunday { get; set; }
        [Required]
        public bool blnMonday { get; set; }
        [Required]
        public bool blnTuesday { get; set; }
        [Required]
        public bool blnWednesday { get; set; }
        [Required]
        public bool blnThursday { get; set; }
        [Required]
        public bool blnFriday { get; set; }
        [Required]
        public bool blnSaturday { get; set; }
        [Required]
        public string strMenuOrderType { get; set; }
        [Required]
        public bool blnDeleted { get; set; }
        [Required]
        public string strFontColor { get; set; }
        [Required]
        public string strButtonColor { get; set; }
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