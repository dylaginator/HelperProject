using System; 
 using WespBasReportingDesktop.Models; 
 public class DimWeekYtd : IWespData { 
	 public int site { get; set; }

	 public int Dim_Week { get; set; }

	 public string Dim_Week_datum { get; set; }

	 public int Dim_Week_SortOrder { get; set; }

	 public string Week_Ytd_eenheden_op_factuur_geklokt { get; set; }

}
