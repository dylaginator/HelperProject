using System; 
 using WespBasReportingDesktop.Models; 
 public class AllSitesJaarrapport : IWespData { 
	 public int site { get; set; }

	 public string site_Algemeen_LaatsteFactuur { get; set; }

	 public string site_Algemeen_LaatsteFactuurDatum { get; set; }

	 public string site_Algemeen_NAW_Adres { get; set; }

	 public string site_Algemeen_NAW_Emailrapportage { get; set; }

	 public string site_Algemeen_NAW_Naambedrijf { get; set; }

	 public string site_Algemeen_NAW_Plaats { get; set; }

	 public string site_Algemeen_NAW_Postcode { get; set; }

	 public int site_Algemeen_TotaalFacturenJaarrapportAlleJaren { get; set; }

}
