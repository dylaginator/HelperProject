using System; 
 using WespBasReportingDesktop.Models; 
 public class DimMaandjaarYtd : IWespData { 
	 public string Dim_My_Ytd { get; set; }

	 public int site { get; set; }

	 public int Dim_My_Ytd_SortOrder { get; set; }

	 public string MY_Ytd_Klok_Efficientie_Prc { get; set; }

	 public string MY_Ytd_Klok_Productiviteit_Prc { get; set; }

	 public string MY_Ytd_Klok_ProductiefUurloon { get; set; }

	 public double MY_Ytd_Uurloon { get; set; }

	 public double MY_Ytd_LoonOmzet { get; set; }

	 public double MY_Ytd_Omzet { get; set; }

	 public double MY_Ytd_GefactureerdeUren { get; set; }

	 public double MY_Ytd_UurPerFact { get; set; }

	 public int MY_Ytd_Fact { get; set; }

	 public double MY_Ytd_LoonPerFact { get; set; }

	 public double MY_Ytd_LoonDelen_Prc { get; set; }

	 public string MY_Ytd_LoonDelen_Prc_Land { get; set; }

}
