using System; 
 using WespBasReportingDesktop.Models; 
 public class DimUursoortklant : IWespData { 
	 public int site { get; set; }

	 public int Dim_UK_SortOrder { get; set; }

	 public string Dim_Uursoortklant { get; set; }

	 public string UK_Ytd_TijdBinnenkomst { get; set; }

	 public string UK_Ytd_TijdVerlofFeestdag { get; set; }

	 public string UK_Ytd_TijdVerlofMedisch { get; set; }

	 public string UK_Ytd_TijdVerlofZiek { get; set; }

	 public string UK_Ytd_TijdVerlof { get; set; }

	 public string UK_Ytd_TijdTraining { get; set; }

	 public string UK_Ytd_TijdProdKlant { get; set; }

	 public string UK_Ytd_TijdProdIntern { get; set; }

	 public string UK_Ytd_TijdPauze { get; set; }

	 public string UK_Ytd_TijdVerlofOverig { get; set; }

	 public string UK_Ytd_TijdNadertebepalen { get; set; }

	 public string UK_Ytd_TijdNietProductief { get; set; }

	 public string UK_Ytd_Totaal { get; set; }

}
