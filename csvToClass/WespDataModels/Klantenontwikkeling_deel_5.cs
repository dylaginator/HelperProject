using System; 
 using WespBasReportingDesktop.Models; 
 public class KlantenontwikkelingDeel5 : IWespData { 
	 public int site { get; set; }

	 public int Dim_Top10Klant_Jaar { get; set; }

	 public string Dim_Top10Klant_Klantnaam { get; set; }

	 public int Dim_Top10Klant_SortOrder { get; set; }

	 public int Top10Klant_Facturen { get; set; }

	 public double Top10Klant_Korting { get; set; }

	 public double Top10Klant_Omzet { get; set; }

	 public string Top10Klant_OmzetPerFact { get; set; }

}
