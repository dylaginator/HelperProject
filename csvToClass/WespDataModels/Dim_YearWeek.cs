using System; 
 using WespBasReportingDesktop.Models; 
 public class DimYearweek : IWespData { 
	 public int site { get; set; }

	 public int Dim_YearWeek { get; set; }

	 public string Dim_YearWeekDate { get; set; }

	 public string YearWeek_DateMin { get; set; }

	 public string YearWeek_DateMax { get; set; }

	 public double YearWeek_Loon { get; set; }

	 public double YearWeek_Omzet { get; set; }

	 public double YearWeek_Marge { get; set; }

	 public double YearWeek_Budget { get; set; }

	 public string YearWeek_Facturen { get; set; }

	 public string YearWeek_LoonPerFactuur { get; set; }

	 public double YearWeek_LoonPerFactuurLand { get; set; }

	 public string YearWeek_OmzetPerFactuur { get; set; }

	 public double YearWeek_OmzetPerFactuurLand { get; set; }

	 public string YearWeek_FacturenPerDag { get; set; }

	 public int werkdagytd { get; set; }

	 public double YearWeek_Uurloon { get; set; }

	 public double YearWeek_GefactureerdeUren { get; set; }

	 public string YearWeek_Prc_LoonDelen { get; set; }

	 public double YearWeek_Prc_LoonDelenLand { get; set; }

	 public string YearWeek_Prc_Marge { get; set; }

	 public double YearWeek_OmzetMinBudget { get; set; }

	 public string YearWeek_Prc_OmzetBudget { get; set; }

	 public int YearWeek_Afspraken { get; set; }

	 public string YearWeek_Prc_MargeOnderdelen { get; set; }

	 public string YearWeek_Prc_MargeTotaal { get; set; }

	 public string YearWeek_Prc_ArtikelMetInkoopprijs { get; set; }

	 public string YearWeek_ArtikelZonderInkoopprijs { get; set; }

	 public double YearWeek_Avg12MndMargeExclInkoop { get; set; }

	 public double YearWeek_Avg12MndAfsprakenPerWeek { get; set; }

	 public double YearWeek_Avg12MndOmzetPerFactuur { get; set; }

	 public double YearWeek_Avg12MndFacturenPerDag { get; set; }

	 public string YearWeek_UrenPerFactuur { get; set; }

}
