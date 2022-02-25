using System; 
 using WespBasReportingDesktop.Models; 
 public class OmzetPerArtikelgroepYtdLytd : IWespData { 
	 public int site { get; set; }

	 public string DimArtGroepStd { get; set; }

	 public int DimArtGroepStd_SortOrder { get; set; }

	 public double Ags_Lytd_Omzet { get; set; }

	 public double Ags_Ytd_Omzet { get; set; }

	 public string Ags_YtdLytd_OmzetVerschil { get; set; }

	 public string Ags_YtdLytd_OmzetVerschil_Prc { get; set; }

	 public double Ags_YtdLytdLand_OmzetVerschil_Prc { get; set; }

	 public int Ags_Jaar1_Header { get; set; }

	 public int Ags_Jaar0_Header { get; set; }

}
