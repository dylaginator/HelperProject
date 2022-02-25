using System; 
 using WespBasReportingDesktop.Models; 
 public class BougieTopBottomAverageNational : IWespData { 
	 public int site { get; set; }

	 public string Dim_MY_L12Mnd { get; set; }

	 public int Dim_MY_L12Mnd_SortOrder { get; set; }

	 public double MY_L12Mnd_bougFact_Prc { get; set; }

	 public double MY_L12Mnd_bougFact_Land_Prc { get; set; }

	 public double MY_L12Mnd_bougFact_Prc_Top100 { get; set; }

	 public double MY_L12Mnd_bougFact_Prc_Bot100 { get; set; }

}
