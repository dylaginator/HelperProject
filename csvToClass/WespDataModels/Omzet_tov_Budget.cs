using System; 
 using WespBasReportingDesktop.Models; 
 public class OmzetTovBudget : IWespData { 
	 public int site { get; set; }

	 public double site_LaatsteMnd_OmzetBudget_Prc { get; set; }

	 public double site_LaatsteMnd_OmzetMinBudget { get; set; }

	 public double site_LaatsteMnd_Omzet { get; set; }

	 public double site_LaatsteMnd_Budget { get; set; }

	 public double site_Ytd_Omzet { get; set; }

	 public double site_Ytd_Budget { get; set; }

	 public double site_Lytd_Omzet { get; set; }

	 public double site_Ytd_OmzetVerschilVorigJaar { get; set; }

	 public int site_Algemeen_Jaardoel { get; set; }

	 public double site_Algemeen_Prognose { get; set; }

	 public double site_Ytd_OmzetBudget_Prc { get; set; }

	 public double site_LaatsteWk_Omzet { get; set; }

	 public double site_LaatsteWk_Budget { get; set; }

	 public double site_Lyfull_Omzet { get; set; }

	 public double site_Algemeen_ScoreOmzetLyVersusPrognose { get; set; }

	 public string site_LaatsteWk_DateFrom { get; set; }

	 public string site_LaatsteWk_DateTo { get; set; }

	 public int site_LaatsteWk_Werkdagen { get; set; }

	 public int site_Ytd_Werkdagen { get; set; }

	 public int site_LaatsteMnd_Werkdag { get; set; }

	 public DateTime site_LaatsteMnd_DateFrom { get; set; }

	 public DateTime site_LaatsteMnd_Title_dateFrom { get; set; }

	 public string site_LaatsteMnd_Title_dateTo { get; set; }

}
