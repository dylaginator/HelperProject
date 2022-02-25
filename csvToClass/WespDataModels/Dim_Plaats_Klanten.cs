using System; 
 using WespBasReportingDesktop.Models; 
 public class DimPlaatsKlanten : IWespData { 
	 public int site { get; set; }

	 public string Dim_KlantPlaats_Plaats { get; set; }

	 public int Dim_KlantPlaats_Plaats_SortOrder { get; set; }

	 public int KlantPlaats_Nieuw { get; set; }

	 public int KlantPlaats_Instromer { get; set; }

	 public int KlantPlaats_Herintreder { get; set; }

	 public double KlantPlaats_Ontwikkeling_Prc { get; set; }

	 public double KlantPlaats_Ontwikkeling_Prc_Land { get; set; }

	 public double KlantPlaats_Herintreders_Prc { get; set; }

	 public double KlantPlaats_Uitstromers_Prc { get; set; }

	 public double KlantPlaats_Nieuw_Prc { get; set; }

	 public int KlantPlaats_Uitstromer { get; set; }

	 public int KlantPlaats_Klanten { get; set; }

	 public int KlantPlaats_GroeiOfKrimp { get; set; }

}
