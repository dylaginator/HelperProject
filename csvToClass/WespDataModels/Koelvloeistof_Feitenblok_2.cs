using System; 
 using WespBasReportingDesktop.Models; 
 public class KoelvloeistofFeitenblok2 : IWespData { 
	 public int site { get; set; }

	 public int Dim_Jaar { get; set; }

	 public int Jaar_Kent { get; set; }

	 public int Jaar_koelVervang { get; set; }

	 public double Jaar_koelVervang_Prc { get; set; }

}
