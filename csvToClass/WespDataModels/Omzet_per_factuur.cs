using System; 
 using WespBasReportingDesktop.Models; 
 public class OmzetPerFactuur : IWespData { 
	 public int site { get; set; }

	 public string DimArtGroepStd { get; set; }

	 public string Ags_Lytd_OmzetPerFact { get; set; }

	 public string Ags_Ytd_OmzetPerFact { get; set; }

	 public string Ags_YtdLytd_OmzetPerFactVerschil_Prc { get; set; }

	 public string Ags_Ytd_OmzetPerFact_Land { get; set; }

	 public string Ags_YtdLand_OmzetPerFactVerschil_Prc { get; set; }

	 public string Ags_4Wk_OmzetPerFact_Land { get; set; }

	 public string Ags_4Wk_OmzetPerFact { get; set; }

	 public string Ags_4WkLand_OmzetPerFactVerschil_Prc { get; set; }

	 public string Ags_mindate { get; set; }

	 public string Ags_maxdate { get; set; }

	 public string Ags__Ly_mindate { get; set; }

	 public int DimArtGroepStd_SortOrder { get; set; }

}
