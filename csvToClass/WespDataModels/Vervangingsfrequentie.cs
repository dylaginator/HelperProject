using System; 
 using WespBasReportingDesktop.Models; 
 public class Vervangingsfrequentie : IWespData { 
	 public int site { get; set; }

	 public string DimArtGroepStd { get; set; }

	 public int DimArtGroepStd_SortOrder { get; set; }

	 public string Ags_Ytd_VervangFreq_Prc { get; set; }

	 public int Ags_Jaar0_Header { get; set; }

}
