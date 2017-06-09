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
	[Alias("tblPersons")]
    public partial class tblPerson 
    {
        [Required]
		[PrimaryKey]
        public Guid uidPersonID { get; set; }
        [Required]
        public string strFirstName { get; set; }
        [Required]
        public string strLastName { get; set; }
        [Required]
        public string strMiddleInitial { get; set; }
        [Required]
        public string strTitle { get; set; }
        [Required]
        public string strSuffix { get; set; }
        public DateTime? dtmBirthDate { get; set; }
        [Required]
        public string strEmail { get; set; }
        [Required]
        public string strNotes { get; set; }
        [Required]
        public Guid uidImageID { get; set; }
        [Required]
        public bool blnOptOutMassEmail { get; set; }
        [Required]
        public Guid uidPersonIDForAddresses { get; set; }
        [Required]
        public DateTimeOffset dtmEnterDateTime { get; set; }
        [Required]
        public string strCasualGreeting { get; set; }
        [Required]
        public string strFormalGreeting { get; set; }
        [Required]
        public string strPostnominals { get; set; }
        [Required]
        public string strOfficesAndHonors { get; set; }
        [Required]
        public string strSpousalGreeting { get; set; }
        [Required]
        public string strJointGreeting { get; set; }
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
