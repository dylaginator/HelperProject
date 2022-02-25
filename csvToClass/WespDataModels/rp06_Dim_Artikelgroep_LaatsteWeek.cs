using System; 
 using WespBasReportingDesktop.Models; 
 public class Rp06DimArtikelgroepLaatsteweek : IWespData { 
	 public int site { get; set; }

	 public string Ags_LaatsteWeek_ArtGroepStd { get; set; }

	 public string Ags_LaatsteWeek_mindate { get; set; }

	 public string Ags_LaatsteWeek_maxdate { get; set; }

	 public double Ags_LaatsteWeek_Omzet { get; set; }

	 public double Ags_LaatsteWeek_nettomarge { get; set; }

	 public double Ags_LaatsteWeek_inkoopwaarde { get; set; }

	 public double Ags_LaatsteWeek_loonomzet { get; set; }

	 public double Ags_LaatsteWeek_delenomzet { get; set; }

	 public string Ags_LaatsteWeek_NettoMarge_Prc { get; set; }

	 public double Ags_LaatsteWeek_BrutoMarge { get; set; }

	 public string Ags_LaatsteWeek_BrutoMarge_Prc { get; set; }

	 public int Ags_LaatsteWeek_SortOrder { get; set; }

}
