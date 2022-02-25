using System; 
 using WespBasReportingDesktop.Models; 
 public class AccuFeitenblok2 : IWespData { 
	 public int site { get; set; }

	 public int Dim_Jaar { get; set; }

	 public int Jaar_Kent { get; set; }

	 public int Jaar_accuVervang { get; set; }

	 public double Jaar_accuVervang_Prc { get; set; }

}
