using System; 
 using WespBasReportingDesktop.Models; 
 public class Rp09 : IWespData { 
	 public int site { get; set; }

	 public string Kenteken { get; set; }

	 public int KLANTNR { get; set; }

	 public int TranslateCode { get; set; }

	 public string DatumDeel1b { get; set; }

	 public string model { get; set; }

	 public string Email { get; set; }

	 public string brand { get; set; }

	 public string APK { get; set; }

	 public string VIN { get; set; }

	 public string LastContactKenteken { get; set; }

	 public string Label { get; set; }

	 public string Customer { get; set; }

	 public string CustomerTel { get; set; }

	 public string LastContactCustomer { get; set; }

	 public string EmailBlock { get; set; }

	 public string TotalInvoiceAmount { get; set; }

	 public string TotalNrOfInvoices { get; set; }

}
