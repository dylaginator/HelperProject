using System; 
 using WespBasReportingDesktop.Models; 
 public class OmzetPerWoonplaats : IWespData { 
	 public int site { get; set; }

	 public string Dim_Plaats { get; set; }

	 public int Dim_Plaats_SortOrder { get; set; }

	 public string Plaats_omzetJr4 { get; set; }

	 public string Plaats_omzetJr3 { get; set; }

	 public string Plaats_omzetJr2 { get; set; }

	 public string Plaats_omzetJr1 { get; set; }

	 public string Plaats_omzetJr0 { get; set; }

	 public int Jaar0_Header { get; set; }

	 public int Jaar1_Header { get; set; }

	 public double Jaar2_Header { get; set; }

	 public int Jaar3_Header { get; set; }

	 public int Jaar4_Header { get; set; }

}
