using System; 
 using WespBasReportingDesktop.Models; 
 public class PrestatieDitJaarTotNu2 : IWespData { 
	 public int site { get; set; }

	 public string DimKerntaak { get; set; }

	 public int DimKerntaak_SortOrder { get; set; }

	 public double Kerntaak_YtdMarkt_Result_Prc { get; set; }

	 public string Kerntaak_LytdYtd_Result_Prc { get; set; }

	 public string DimKerntaak_DateMaxLastMonth { get; set; }

}
