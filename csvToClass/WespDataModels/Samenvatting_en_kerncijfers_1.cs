using System; 
 using WespBasReportingDesktop.Models; 
 public class SamenvattingEnKerncijfers1 : IWespData { 
	 public int site { get; set; }

	 public int Dim_Jaar { get; set; }

	 public double Jaar_Omzet { get; set; }

	 public int Jaar_Fact { get; set; }

	 public double Jaar_FactPerDag { get; set; }

	 public double Jaar_omzetPerFact { get; set; }

	 public double Jaar_loonPerFact { get; set; }

	 public double Jaar_delenPerFact { get; set; }

	 public int Jaar_Kent { get; set; }

	 public int Jaar_Klant { get; set; }

	 public double Jaar_OmzetPerDag { get; set; }

	 public double Jaar_LoonDelenPerFact_Prc { get; set; }

	 public double Jaar_OmzetPerKentCOO { get; set; }

	 public double Jaar_OmzetPerKlant { get; set; }

	 public double Jaar_ContactenPerKent { get; set; }

	 public double Jaar_OntwikkelingKlant_Prc { get; set; }

}
