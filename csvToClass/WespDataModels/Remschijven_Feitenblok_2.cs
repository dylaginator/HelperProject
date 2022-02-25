using System; 
 using WespBasReportingDesktop.Models; 
 public class RemschijvenFeitenblok2 : IWespData { 
	 public int site { get; set; }

	 public int Dim_Jaar { get; set; }

	 public int Jaar_Kent { get; set; }

	 public int Jaar_remscVervang { get; set; }

	 public double Jaar_remscVervang_Prc { get; set; }

}
