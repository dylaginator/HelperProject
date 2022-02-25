using System; 
 using WespBasReportingDesktop.Models; 
 public class KlantenontwikkelingDeel2 : IWespData { 
	 public int site { get; set; }

	 public string Dim_KlantPlaats_Plaats { get; set; }

	 public int Dim_KlantPlaats_Plaats_SortOrder { get; set; }

	 public int KlantPlaats_GroeiOfKrimp { get; set; }

	 public int KlantPlaats_Instromer { get; set; }

	 public int KlantPlaats_Klanten { get; set; }

	 public double KlantPlaats_Ontwikkeling_Prc { get; set; }

	 public double KlantPlaats_Ontwikkeling_Prc_Land { get; set; }

	 public int KlantPlaats_Uitstromer { get; set; }

}
