using System; 
 using WespBasReportingDesktop.Models; 
 public class Rp311 : IWespData { 
	 public int site { get; set; }

	 public double site_LaatsteWk_OmzetPerFact { get; set; }

	 public double site_Ytd_OmzetPerFact { get; set; }

	 public double site_LaatsteWk_LoonDelen_Prc { get; set; }

	 public double site_Ytd_LoonDelen_Prc { get; set; }

	 public double site_LaatsteWk_LoonPerFact { get; set; }

	 public double site_Ytd_LoonPerFact { get; set; }

	 public int site_LaatsteWk_Fact { get; set; }

	 public int site_LaatsteWk_Werkdagen { get; set; }

	 public string site_LaatsteWk_DateFrom { get; set; }

	 public string site_LaatsteWk_DateTo { get; set; }

	 public double site_LaatsteWk_OmzetPerDag { get; set; }

	 public double site_LaatsteWk_Omzet { get; set; }

	 public double site_LaatsteWk_OmzetBeurt { get; set; }

	 public double site_LaatsteWk_kleinEnBeurtFact_Prc { get; set; }

	 public int site_LaatsteWk_oliefFact { get; set; }

	 public double site_LaatsteWk_oliefFact_Prc { get; set; }

	 public double site_LaatsteWk_GemOmzetBeurt { get; set; }

	 public double site_LaatsteWk_AantalLitersOlieSmeerm { get; set; }

	 public int site_LaatsteWk_olieBijvulFact { get; set; }

	 public int site_LaatsteWk_apkFact { get; set; }

	 public int site_Ytd_Klanten { get; set; }

	 public double site_Algemeen_Prognose { get; set; }

	 public double site_Ytd_BrutoMarge_Prc { get; set; }

	 public double site_Ytd_NettoMargeDelen_Prc { get; set; }

	 public int site_Algemeen_Jaardoel { get; set; }

	 public double site_Lytd_BrutoMarge_Prc { get; set; }

	 public double site_Lytd_NettoMargeDelen_Prc { get; set; }

	 public double site_LaatsteWk_BrutoMarge_Prc { get; set; }

	 public double site_LaatsteWk_NettoMargeDelen_Prc { get; set; }

	 public double site_LaatsteWk_OmzetApk { get; set; }

	 public double site_LaatsteWk_OmzetApkTijdensBeurt { get; set; }

	 public int site_LaatsteWk_factLosseApk { get; set; }

	 public int rp31_instroom { get; set; }

	 public int rp31_uitstroom { get; set; }

}
