using System; 
 using WespBasReportingDesktop.Models; 
 public class DimKerntaken : IWespData { 
	 public int site { get; set; }

	 public string DimKerntaak { get; set; }

	 public int DimKerntaak_SortOrder { get; set; }

	 public double Kerntaak_YtdMarkt_Result_Prc { get; set; }

	 public string Kerntaak_LytdYtd_Result_Prc { get; set; }

	 public string Kerntaak_4Wk12Mnd_Result_Prc { get; set; }

	 public string Kerntaak_4WkMarkt_Result_Prc { get; set; }

	 public int Kerntaak_4WkMarkt_Result_Prios { get; set; }

	 public string Kerntaak_LWk4Wk_Result_Prc { get; set; }

	 public int Kerntaak_LWk4Wk_Result_Prios { get; set; }

	 public string DimKerntaak_DateMaxLastMonth { get; set; }

}
