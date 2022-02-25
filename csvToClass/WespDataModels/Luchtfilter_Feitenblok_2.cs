using System; 
 using WespBasReportingDesktop.Models; 
 public class LuchtfilterFeitenblok2 : IWespData { 
	 public int site { get; set; }

	 public int Dim_Jaar { get; set; }

	 public int Jaar_Kent { get; set; }

	 public int Jaar_luchtVervang { get; set; }

	 public double Jaar_luchtVervang_Prc { get; set; }

}
