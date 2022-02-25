using System; 
 using WespBasReportingDesktop.Models; 
 public class KerncijfersDitJaarTotNu3 : IWespData { 
	 public int site { get; set; }

	 public string Dim_MY_L12Mnd { get; set; }

	 public int Dim_MY_L12Mnd_SortOrder { get; set; }

	 public double MY_L12Mnd_OmzetPerFact { get; set; }

	 public double MY_L12Mnd_FactPerWerkdag { get; set; }

}
