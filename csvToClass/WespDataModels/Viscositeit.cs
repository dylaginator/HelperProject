using System; 
 using WespBasReportingDesktop.Models; 
 public class Viscositeit : IWespData { 
	 public string Dim_Visco { get; set; }

	 public int site { get; set; }

	 public double Visco_Omzetaandeel_Prc { get; set; }

	 public double Visco_Omzetaandeel_Land_Prc { get; set; }

	 public double Visco_Prijs { get; set; }

	 public double Visco_Omzet { get; set; }

	 public double Visco_Prijs_Land { get; set; }

}
