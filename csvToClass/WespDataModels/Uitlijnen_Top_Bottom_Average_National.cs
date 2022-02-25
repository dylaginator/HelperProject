using System; 
 using WespBasReportingDesktop.Models; 
 public class UitlijnenTopBottomAverageNational : IWespData { 
	 public int site { get; set; }

	 public string Dim_MY_L12Mnd { get; set; }

	 public int Dim_MY_L12Mnd_SortOrder { get; set; }

	 public string MY_L12Mnd_uitlijnFact_Prc { get; set; }

	 public double MY_L12Mnd_uitlijnFact_Land_Prc { get; set; }

	 public double MY_L12Mnd_uitlijnFact_Prc_Top100 { get; set; }

	 public double MY_L12Mnd_uitlijnFact_Prc_Bot100 { get; set; }

}
