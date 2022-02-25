using System; 
 using WespBasReportingDesktop.Models; 
 public class Prijsniveau : IWespData { 
	 public int site { get; set; }

	 public string DimArtGroepStd { get; set; }

	 public int DimArtGroepStd_SortOrder { get; set; }

	 public string Ags_Jaar4_Prijs { get; set; }

	 public string Ags_Jaar3_Prijs { get; set; }

	 public string Ags_Jaar2_Prijs { get; set; }

	 public string Ags_Jaar1_Prijs { get; set; }

	 public string Ags_Jaar0_Prijs { get; set; }

	 public int Ags_Jaar4_Header { get; set; }

	 public int Ags_Jaar3_Header { get; set; }

	 public int Ags_Jaar2_Header { get; set; }

	 public int Ags_Jaar1_Header { get; set; }

	 public int Ags_Jaar0_Header { get; set; }

}
