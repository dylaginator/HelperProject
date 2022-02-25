using System; 
 using WespBasReportingDesktop.Models; 
 public class Rp40Gauges : IWespData { 
	 public int site { get; set; }

	 public string rp40_dim_monteur { get; set; }

	 public string tijdklantgeklokt_maandag { get; set; }

	 public string tijdklantgeklokt_dinsdag { get; set; }

	 public double tijdklantgeklokt_woensdag { get; set; }

	 public double tijdklantgeklokt_donderdag { get; set; }

	 public double tijdklantgeklokt_vrijdag { get; set; }

	 public double tijdklantgeklokt_zaterdag { get; set; }

	 public double tijdklantgeklokt_totaal { get; set; }

	 public double rp40_gauge_score_klok_maandag { get; set; }

	 public double rp40_gauge_score_klok_dinsdag { get; set; }

	 public double rp40_gauge_score_klok_woensdag { get; set; }

	 public double rp40_gauge_score_klok_donderdag { get; set; }

	 public double rp40_gauge_score_klok_vrijdag { get; set; }

	 public double rp40_gauge_score_klok_zaterdag { get; set; }

	 public double rp40_gauge_score_klok_totaal { get; set; }

	 public double rp40_gauge_MIN_klok_maandag { get; set; }

	 public double rp40_gauge_MAX_klok_maandag { get; set; }

	 public double rp40_gauge_MIN_klok_dinsdag { get; set; }

	 public double rp40_gauge_MAX_klok_dinsdag { get; set; }

	 public double rp40_gauge_MIN_klok_woensdag { get; set; }

	 public double rp40_gauge_MAX_klok_woensdag { get; set; }

	 public double rp40_gauge_MIN_klok_donderdag { get; set; }

	 public double rp40_gauge_MAX_klok_donderdag { get; set; }

	 public double rp40_gauge_MIN_klok_vrijdag { get; set; }

	 public double rp40_gauge_MAX_klok_vrijdag { get; set; }

	 public double rp40_gauge_MIN_klok_zaterdag { get; set; }

	 public double rp40_gauge_MAX_klok_zaterdag { get; set; }

	 public double rp40_gauge_MIN_klok_totaal { get; set; }

	 public double rp40_gauge_MAX_klok_totaal { get; set; }

	 public string date_maandag { get; set; }

	 public string date_dinsdag { get; set; }

	 public string date_woensdag { get; set; }

	 public string date_donderdag { get; set; }

	 public string date_vrijdag { get; set; }

	 public string date_zaterdag { get; set; }

}
