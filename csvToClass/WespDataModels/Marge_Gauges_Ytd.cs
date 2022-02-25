using System; 
 using WespBasReportingDesktop.Models; 
 public class MargeGaugesYtd : IWespData { 
	 public int site { get; set; }

	 public double site_Ytd_BrutoMarge_Prc { get; set; }

	 public double site_Ytd_NettoMargeDelen_Prc { get; set; }

	 public double site_Ytd_OmzetMetInkoopwaarde_Prc { get; set; }

}
