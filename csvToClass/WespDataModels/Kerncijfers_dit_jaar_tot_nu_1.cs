using System; 
 using WespBasReportingDesktop.Models; 
 public class KerncijfersDitJaarTotNu1 : IWespData { 
	 public int site { get; set; }

	 public string Dim_Maand { get; set; }

	 public int Dim_Maand_SortOrder { get; set; }

	 public string Maand_Klok_Ytd_Efficientie_Prc { get; set; }

	 public string Maand_Lytd_Omzet { get; set; }

	 public string Maand_Ytd_Omzet { get; set; }

	 public string Maand_Ytd_Fact { get; set; }

	 public string Maand_YtdLytd_Fact_Prc { get; set; }

	 public string Maand_Lytd_Fact { get; set; }

	 public string Maand_Lytd_OmzetPerFactuur { get; set; }

	 public string Maand_Ytd_OmzetPerFactuur { get; set; }

	 public string Maand_YtdLytd_OmzetVerschil_Prc { get; set; }

	 public string Maand_YtdLytd_OmzetPerFact_Prc { get; set; }

	 public string Maand_YtdLytd_OmzetVerschil { get; set; }

	 public string Maand_Ytd_Startdate { get; set; }

	 public string Maand_Lytd_StartDate { get; set; }

	 public string Maand_Ytd_Enddate { get; set; }

}
