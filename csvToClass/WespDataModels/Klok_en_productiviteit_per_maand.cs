using System; 
 using WespBasReportingDesktop.Models; 
 public class KlokEnProductiviteitPerMaand : IWespData { 
	 public int site { get; set; }

	 public string Dim_Maand { get; set; }

	 public int Dim_Maand_SortOrder { get; set; }

	 public string Maand_Klok_Ytd_BrutoUren { get; set; }

	 public string Maand_Klok_Ytd_OverUren { get; set; }

	 public string Maand_Klok_Ytd_Ziek { get; set; }

	 public string Maand_Klok_Ytd_Cursus { get; set; }

	 public string Maand_Klok_Ytd_Verlof { get; set; }

	 public string Maand_Klok_Ytd_AfwezigTotaal { get; set; }

	 public string Maand_Klok_Ytd_NettoBeschikbaar { get; set; }

	 public string Maand_Klok_Ytd_NettoBeschikbaarAlsMonteur { get; set; }

	 public string Maand_Klok_Ytd_KlantGeklokt { get; set; }

	 public string Maand_Klok_Ytd_InternGeklokt { get; set; }

	 public string Maand_Klok_Ytd_VerantwoordDoorMonteurGeklokt { get; set; }

	 public string Maand_Klok_Ytd_Bezettingsgraad_Prc { get; set; }

	 public string Maand_Klok_Ytd_BezettingsgraadWo_Prc { get; set; }

	 public string Maand_Klok_Ytd_UrenverkochtFact { get; set; }

	 public string Maand_Klok_Ytd_Productiviteit_Prc { get; set; }

	 public string Maand_Klok_Ytd_Loonomzet { get; set; }

	 public string Maand_Klok_Ytd_ProductiefUurloon { get; set; }

	 public string Maand_Klok_Ytd_PrognoseUrenPerJaar { get; set; }

	 public string Maand_Klok_Ytd_Uurloon { get; set; }

	 public string Maand_Klok_Ytd_Efficientie_Prc { get; set; }

	 public string Maand_Ytd_Omzet { get; set; }

}
