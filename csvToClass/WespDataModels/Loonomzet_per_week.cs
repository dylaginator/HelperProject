using System; 
 using WespBasReportingDesktop.Models; 
 public class LoonomzetPerWeek : IWespData { 
	 public int site { get; set; }

	 public string Dim_Week { get; set; }

	 public string Dim_Week_datum { get; set; }

	 public int Dim_Week_SortOrder { get; set; }

	 public string Week_Ytd_Fact { get; set; }

	 public string Week_Ytd_GefactureerdeUren { get; set; }

	 public string Week_Ytd_LoonDelen_Prc { get; set; }

	 public string Week_Ytd_LoonOmzet { get; set; }

	 public string Week_Ytd_LoonPerFact { get; set; }

	 public string Week_Ytd_Uurloon { get; set; }

	 public string Week_Ytd_UurPerFact { get; set; }

}
