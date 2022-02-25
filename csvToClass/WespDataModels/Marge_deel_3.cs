using System; 
 using WespBasReportingDesktop.Models; 
 public class MargeDeel3 : IWespData { 
	 public int site { get; set; }

	 public string Dim_Maand { get; set; }

	 public int Dim_Maand_SortOrder { get; set; }

	 public string Maand_Ytd_ArtikelnrsZonderInkoopwaarde { get; set; }

	 public string Maand_Ytd_ArtikelnrsMetInkoopwaarde_Prc { get; set; }

	 public string Maand_Ytd_MargeDelen_Prc { get; set; }

	 public string Maand_Ytd_Marge_Prc { get; set; }

}
