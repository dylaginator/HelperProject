using System; 
 using WespBasReportingDesktop.Models; 
 public class DistributieEnWaterpompenFeitenblok2 : IWespData { 
	 public int site { get; set; }

	 public int Dim_Jaar { get; set; }

	 public int Jaar_Kent { get; set; }

	 public int Jaar_distriVervang { get; set; }

	 public double Jaar_distriVervang_Prc { get; set; }

}
