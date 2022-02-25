using System; 
 using WespBasReportingDesktop.Models; 
 public class DimRp24 : IWespData { 
	 public int site { get; set; }

	 public string Dim_Eff_LaatsteWk_Factnr { get; set; }

	 public string Eff_LaatsteWk_geklokt { get; set; }

	 public string Eff_LaatsteWk_urenVerkocht { get; set; }

	 public string Eff_LaatsteWk_verschil { get; set; }

	 public double Eff_LaatsteWk_efficientie { get; set; }

	 public double Eff_LaatsteWk_loon { get; set; }

	 public string Eff_LaatsteWk_productiefUurloon { get; set; }

	 public string Eff_LaatsteWk_loonDelen_Prc { get; set; }

	 public string Eff_LaatsteWk_monteur { get; set; }

	 public string Eff_LaatsteWk_margeonderdelen_Prc { get; set; }

	 public string Eff_LaatsteWk_margetotaal_Prc { get; set; }

}
