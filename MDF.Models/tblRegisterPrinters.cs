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
	[Alias("tblRegisterPrinters")]
    public partial class tblRegisterPrinter 
    {
        [Required]
		[PrimaryKey]
        public Guid uidRegisterPrinterID { get; set; }
        [Required]
        public string strName { get; set; }
        [Required]
        public string strWindowsPrinterName { get; set; }
        [Required]
        public Guid uidDeptID { get; set; }
        [Required]
        public bool blnThermalPrinter { get; set; }
        [Required]
        public int lngNumberOfLinesToAdvanceAtEnd { get; set; }
        [Required]
        public bool blnPrintStarterTicket { get; set; }
        [Required]
        public bool blnPopCashDrawer { get; set; }
        [Required]
        public string strPopCashDrawerCommand { get; set; }
        [Required]
        public bool blnCutPaper { get; set; }
        [Required]
        public string strCutPaperCommand { get; set; }
        [Required]
        public string strTurnOnBigLettersPrintCode { get; set; }
        [Required]
        public string strTurnOffBigLettersPrintCode { get; set; }
        [Required]
        public string strTurnOnRedLettersPrintCode { get; set; }
        [Required]
        public string strTurnOffRedLettersPrintCode { get; set; }
        [Required]
        public bool blnBuzzer { get; set; }
        [Required]
        public string strBuzzerPrintCode { get; set; }
        [Required]
        public bool blnMultiplePrinter { get; set; }
        [Required]
        public string strPrinterModel { get; set; }
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