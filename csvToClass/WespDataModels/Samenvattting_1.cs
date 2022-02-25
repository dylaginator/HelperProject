using System; 
 using WespBasReportingDesktop.Models; 
 public class Samenvattting1 : IWespData { 
	 public int site { get; set; }

	 public int Dim_Jaar { get; set; }

	 public double Jaar_OmzetPerKentCOO { get; set; }

	 public double Jaar_OmzetPerKentCOO_Land { get; set; }

	 public double Jaar_ContactenPerKent { get; set; }

	 public double Jaar_ContactenPerKent_Land { get; set; }

	 public double Jaar_LoonDelenPerFact_Prc { get; set; }

	 public double Jaar_LoonDelenPerFact_Prc_Land { get; set; }

	 public double Jaar_omzetPerFact { get; set; }

	 public double Jaar_OmzetPerFact_Land { get; set; }

}
