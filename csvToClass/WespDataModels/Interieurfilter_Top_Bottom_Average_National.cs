using System; 
 using WespBasReportingDesktop.Models; 
 public class InterieurfilterTopBottomAverageNational : IWespData { 
	 public int site { get; set; }

	 public string Dim_MY_L12Mnd { get; set; }

	 public int Dim_MY_L12Mnd_SortOrder { get; set; }

	 public double MY_L12Mnd_intfFact_Prc { get; set; }

	 public double MY_L12Mnd_intfFact_Land_Prc { get; set; }

	 public double MY_L12Mnd_intfFact_Prc_Top100 { get; set; }

	 public double MY_L12Mnd_intfFact_Prc_Bot100 { get; set; }

}
