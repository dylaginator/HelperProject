using System; 
 using WespBasReportingDesktop.Models; 
 public class DimSites : IWespData { 
	 public int site { get; set; }

	 public int weeknr { get; set; }

	 public int site_Algemeen_Jaardoel { get; set; }

	 public string site_Algemeen_LastFullMonthEnd { get; set; }

	 public string site_LaatsteMnd_Title_dateTo { get; set; }

	 public DateTime site_LaatsteMnd_Title_dateFrom { get; set; }

	 public DateTime site_L12Mnd_Mindate { get; set; }

	 public string site_L12Mnd_Maxdate { get; set; }

	 public string site_Algemeen_LaatsteFactuur { get; set; }

	 public string site_Algemeen_LaatsteFactuurDatum { get; set; }

	 public string site_Algemeen_NAW_Adres { get; set; }

	 public string site_Algemeen_NAW_Emailrapportage { get; set; }

	 public string site_Algemeen_NAW_Naambedrijf { get; set; }

	 public string site_Algemeen_NAW_Plaats { get; set; }

	 public string site_Algemeen_NAW_Postcode { get; set; }

	 public string site_Algemeen_RP_nummers { get; set; }

	 public double site_Algemeen_Prognose { get; set; }

	 public int site_Algemeen_Rank_Max { get; set; }

	 public double site_Algemeen_ScoreOmzetLyVersusPrognose { get; set; }

	 public int site_Algemeen_TotaalFacturenJaarrapportAlleJaren { get; set; }

	 public double site_Algemeen_Uurloon { get; set; }

	 public int site_L12Mnd_accu_KentRank { get; set; }

	 public double site_L12Mnd_accuCOO { get; set; }

	 public double site_L12Mnd_accuCOO_Land { get; set; }

	 public double site_L12Mnd_accuCOO_Top100 { get; set; }

	 public int site_L12Mnd_accuEnBeurtFact { get; set; }

	 public int site_L12Mnd_accuFact { get; set; }

	 public double site_L12Mnd_accuGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_accuGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_accuGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_accuGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_accuOmzet { get; set; }

	 public int site_L12Mnd_accuVervang { get; set; }

	 public int site_L12Mnd_airc_KentRank { get; set; }

	 public int site_L12Mnd_aircEnBeurtFact { get; set; }

	 public int site_L12Mnd_aircFact { get; set; }

	 public double site_L12Mnd_aircGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_aircGemistAantalTovTop100 { get; set; }

	 public int site_L12Mnd_aircVervang { get; set; }

	 public int site_L12Mnd_Autos { get; set; }

	 public int site_L12Mnd_band_KentRank { get; set; }

	 public double site_L12Mnd_bandCOO { get; set; }

	 public double site_L12Mnd_bandCOO_Land { get; set; }

	 public double site_L12Mnd_bandCOO_Top100 { get; set; }

	 public int site_L12Mnd_bandEnBeurtFact { get; set; }

	 public int site_L12Mnd_bandFact { get; set; }

	 public double site_L12Mnd_bandGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_bandGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_bandGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_bandGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_bandOmzet { get; set; }

	 public int site_L12Mnd_bandVervang { get; set; }

	 public int site_L12Mnd_boug_KentRank { get; set; }

	 public double site_L12Mnd_bougCOO { get; set; }

	 public double site_L12Mnd_bougCOO_Land { get; set; }

	 public double site_L12Mnd_bougCOO_Top100 { get; set; }

	 public int site_L12Mnd_bougEnBeurtFact { get; set; }

	 public int site_L12Mnd_bougFact { get; set; }

	 public double site_L12Mnd_bougGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_bougGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_bougGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_bougGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_bougOmzet { get; set; }

	 public int site_L12Mnd_bougVervang { get; set; }

	 public int site_L12Mnd_distri_KentRank { get; set; }

	 public double site_L12Mnd_distriCOO { get; set; }

	 public double site_L12Mnd_distriCOO_Land { get; set; }

	 public double site_L12Mnd_distriCOO_Top100 { get; set; }

	 public int site_L12Mnd_distriEnBeurtFact { get; set; }

	 public int site_L12Mnd_distriFact { get; set; }

	 public double site_L12Mnd_distriGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_distriGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_distriGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_distriGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_distriOmzet { get; set; }

	 public int site_L12Mnd_distriVervang { get; set; }

	 public int site_L12Mnd_Fact { get; set; }

	 public int site_L12Mnd_intf_KentRank { get; set; }

	 public double site_L12Mnd_intfCOO { get; set; }

	 public double site_L12Mnd_intfCOO_Land { get; set; }

	 public double site_L12Mnd_intfCOO_Top100 { get; set; }

	 public int site_L12Mnd_intfEnBeurtFact { get; set; }

	 public int site_L12Mnd_intfFact { get; set; }

	 public double site_L12Mnd_intfGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_intfGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_intfGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_intfGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_intfOmzet { get; set; }

	 public int site_L12Mnd_intfVervang { get; set; }

	 public int site_L12Mnd_klein_KentRank { get; set; }

	 public double site_L12Mnd_kleinCOO { get; set; }

	 public double site_L12Mnd_kleinCOO_Land { get; set; }

	 public double site_L12Mnd_kleinCOO_Top100 { get; set; }

	 public int site_L12Mnd_kleinEnBeurtFact { get; set; }

	 public int site_L12Mnd_kleinFact { get; set; }

	 public double site_L12Mnd_kleinGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_kleinGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_kleinGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_kleinGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_kleinOmzet { get; set; }

	 public int site_L12Mnd_kleinVervang { get; set; }

	 public int site_L12Mnd_koel_KentRank { get; set; }

	 public double site_L12Mnd_koelCOO { get; set; }

	 public double site_L12Mnd_koelCOO_Land { get; set; }

	 public double site_L12Mnd_koelCOO_Top100 { get; set; }

	 public int site_L12Mnd_koelEnBeurtFact { get; set; }

	 public int site_L12Mnd_koelFact { get; set; }

	 public double site_L12Mnd_koelGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_koelGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_koelGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_koelGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_koelOmzet { get; set; }

	 public int site_L12Mnd_koelVervang { get; set; }

	 public int site_L12Mnd_lucht_KentRank { get; set; }

	 public double site_L12Mnd_luchtCOO { get; set; }

	 public double site_L12Mnd_luchtCOO_Land { get; set; }

	 public double site_L12Mnd_luchtCOO_Top100 { get; set; }

	 public int site_L12Mnd_luchtEnBeurtFact { get; set; }

	 public int site_L12Mnd_luchtFact { get; set; }

	 public double site_L12Mnd_luchtGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_luchtGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_luchtGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_luchtGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_luchtOmzet { get; set; }

	 public int site_L12Mnd_luchtVervang { get; set; }

	 public int site_L12Mnd_olief_KentRank { get; set; }

	 public double site_L12Mnd_oliefCOO { get; set; }

	 public double site_L12Mnd_oliefCOO_Land { get; set; }

	 public double site_L12Mnd_oliefCOO_Top100 { get; set; }

	 public int site_L12Mnd_oliefFact { get; set; }

	 public double site_L12Mnd_oliefGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_oliefGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_oliefGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_oliefGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_oliefOmzet { get; set; }

	 public int site_L12Mnd_oliefVervang { get; set; }

	 public int site_L12Mnd_pech_KentRank { get; set; }

	 public int site_L12Mnd_pechEnBeurtFact { get; set; }

	 public int site_L12Mnd_pechFact { get; set; }

	 public double site_L12Mnd_pechGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_pechGemistAantalTovTop100 { get; set; }

	 public int site_L12Mnd_pechVervang { get; set; }

	 public int site_L12Mnd_rembl_KentRank { get; set; }

	 public double site_L12Mnd_remblCOO { get; set; }

	 public double site_L12Mnd_remblCOO_Land { get; set; }

	 public double site_L12Mnd_remblCOO_Top100 { get; set; }

	 public int site_L12Mnd_remblEnBeurtFact { get; set; }

	 public int site_L12Mnd_remblFact { get; set; }

	 public double site_L12Mnd_remblGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_remblGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_remblGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_remblGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_remblOmzet { get; set; }

	 public int site_L12Mnd_remblVervang { get; set; }

	 public int site_L12Mnd_remsc_KentRank { get; set; }

	 public double site_L12Mnd_remscCOO { get; set; }

	 public double site_L12Mnd_remscCOO_Land { get; set; }

	 public double site_L12Mnd_remscCOO_Top100 { get; set; }

	 public int site_L12Mnd_remscEnBeurtFact { get; set; }

	 public int site_L12Mnd_remscFact { get; set; }

	 public double site_L12Mnd_remscGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_remscGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_remscGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_remscGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_remscOmzet { get; set; }

	 public int site_L12Mnd_remscVervang { get; set; }

	 public int site_L12Mnd_remvl_KentRank { get; set; }

	 public int site_L12Mnd_remvlEnBeurtFact { get; set; }

	 public int site_L12Mnd_remvlFact { get; set; }

	 public double site_L12Mnd_remvlGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_remvlGemistAantalTovTop100 { get; set; }

	 public int site_L12Mnd_remvlVervang { get; set; }

	 public int site_L12Mnd_ruitw_KentRank { get; set; }

	 public double site_L12Mnd_ruitwCOO { get; set; }

	 public double site_L12Mnd_ruitwCOO_Land { get; set; }

	 public double site_L12Mnd_ruitwCOO_Top100 { get; set; }

	 public int site_L12Mnd_ruitwEnBeurtFact { get; set; }

	 public int site_L12Mnd_ruitwFact { get; set; }

	 public double site_L12Mnd_ruitwGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_ruitwGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_ruitwGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_ruitwGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_ruitwOmzet { get; set; }

	 public int site_L12Mnd_ruitwVervang { get; set; }

	 public int site_L12Mnd_sproei_KentRank { get; set; }

	 public double site_L12Mnd_sproeiCOO { get; set; }

	 public double site_L12Mnd_sproeiCOO_Land { get; set; }

	 public double site_L12Mnd_sproeiCOO_Top100 { get; set; }

	 public int site_L12Mnd_sproeiEnBeurtFact { get; set; }

	 public int site_L12Mnd_sproeiFact { get; set; }

	 public double site_L12Mnd_sproeiGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_sproeiGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_sproeiGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_sproeiGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_sproeiOmzet { get; set; }

	 public int site_L12Mnd_sproeiVervang { get; set; }

	 public int site_L12Mnd_stuur_KentRank { get; set; }

	 public double site_L12Mnd_stuurCOO { get; set; }

	 public double site_L12Mnd_stuurCOO_Land { get; set; }

	 public double site_L12Mnd_stuurCOO_Top100 { get; set; }

	 public int site_L12Mnd_stuurEnBeurtFact { get; set; }

	 public int site_L12Mnd_stuurFact { get; set; }

	 public double site_L12Mnd_stuurGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_stuurGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_stuurGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_stuurGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_stuurOmzet { get; set; }

	 public int site_L12Mnd_stuurVervang { get; set; }

	 public int site_L12Mnd_uitlaat_KentRank { get; set; }

	 public double site_L12Mnd_uitlaatCOO { get; set; }

	 public double site_L12Mnd_uitlaatCOO_Land { get; set; }

	 public double site_L12Mnd_uitlaatCOO_Top100 { get; set; }

	 public int site_L12Mnd_uitlaatEnBeurtFact { get; set; }

	 public int site_L12Mnd_uitlaatFact { get; set; }

	 public double site_L12Mnd_uitlaatGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_uitlaatGemistAantalTovTop100 { get; set; }

	 public double site_L12Mnd_uitlaatGemistBedragTovGem { get; set; }

	 public double site_L12Mnd_uitlaatGemistBedragTovTop100 { get; set; }

	 public double site_L12Mnd_uitlaatOmzet { get; set; }

	 public int site_L12Mnd_uitlaatVervang { get; set; }

	 public int site_L12Mnd_uitlijn_KentRank { get; set; }

	 public int site_L12Mnd_uitlijnEnBeurtFact { get; set; }

	 public int site_L12Mnd_uitlijnFact { get; set; }

	 public double site_L12Mnd_uitlijnGemistAantalTovGem { get; set; }

	 public double site_L12Mnd_uitlijnGemistAantalTovTop100 { get; set; }

	 public int site_L12Mnd_uitlijnVervang { get; set; }

	 public int site_L12Wk_Klok_AfwezigTotaal { get; set; }

	 public int site_L12Wk_Klok_BrutoUrenBeschikbaar { get; set; }

	 public int site_L12Wk_Klok_Cursus { get; set; }

	 public double site_L12Wk_Klok_Efficientie { get; set; }

	 public double site_L12Wk_Klok_InternGeklokt { get; set; }

	 public double site_L12Wk_Klok_KlantGeklokt { get; set; }

	 public double site_L12Wk_Klok_LoonOmzet { get; set; }

	 public double site_L12Wk_Klok_NettoOmzet { get; set; }

	 public double site_L12Wk_Klok_OmzetTotaal { get; set; }

	 public double site_L12Wk_Klok_OmzetPerMonteurPrognose { get; set; }

	 public int site_L12Wk_Klok_NettoBeschikbaar { get; set; }

	 public int site_L12Wk_Klok_NettoBeschikbaarAlsMonteur { get; set; }

	 public int site_L12Wk_Klok_overUren { get; set; }

	 public double site_L12Wk_Klok_ProductiefUurloon { get; set; }

	 public double site_L12Wk_Klok_PrognoseUrenPerJaar { get; set; }

	 public int site_L12Wk_Klok_PrognUrenVerkochtPerMonteur { get; set; }

	 public double site_L12Wk_Klok_TrainingsdagenPerMonteur { get; set; }

	 public int site_L12Wk_Klok_UrenOpKlantGeklokt { get; set; }

	 public double site_L12Wk_Klok_UrenverkochtFact { get; set; }

	 public double site_L12Wk_Klok_VerantwoordDoorMonteurGeklokt { get; set; }

	 public int site_L12Wk_Klok_Verlof { get; set; }

	 public int site_L12Wk_Klok_Ziek { get; set; }

	 public int site_L4Wk_accuEnBeurtFact { get; set; }

	 public int site_L4Wk_accuFact { get; set; }

	 public int site_L4Wk_bandEnBeurtFact { get; set; }

	 public int site_L4Wk_bandFact { get; set; }

	 public int site_L4Wk_bougEnBeurtFact { get; set; }

	 public int site_L4Wk_bougFact { get; set; }

	 public int site_L4Wk_distriEnBeurtFact { get; set; }

	 public int site_L4Wk_distriFact { get; set; }

	 public int site_L4Wk_Facturen { get; set; }

	 public double site_L4Wk_GefactureerdeUren { get; set; }

	 public int site_L4Wk_intfEnBeurtFact { get; set; }

	 public int site_L4Wk_intfFact { get; set; }

	 public int site_L4Wk_kleinEnBeurtFact { get; set; }

	 public int site_L4Wk_kleinFact { get; set; }

	 public int site_L4Wk_koelEnBeurtFact { get; set; }

	 public int site_L4Wk_koelFact { get; set; }

	 public double site_L4Wk_Loon { get; set; }

	 public double site_L4Wk_LoonPerFact { get; set; }

	 public double site_L4Wk_LoonPerFact_Land { get; set; }

	 public double site_L4Wk_LoonPerFact_LandLy { get; set; }

	 public int site_L4Wk_luchtEnBeurtFact { get; set; }

	 public int site_L4Wk_luchtFact { get; set; }

	 public int site_L4Wk_oliefFact { get; set; }

	 public double site_L4Wk_OmzetPerFact { get; set; }

	 public double site_L4Wk_OmzetPerFact_Land { get; set; }

	 public double site_L4Wk_OmzetPerFact_LandLy { get; set; }

	 public double site_L4Wk_OmzetPerFact_Ly { get; set; }

	 public int site_L4Wk_remblEnBeurtFact { get; set; }

	 public int site_L4Wk_remblFact { get; set; }

	 public int site_L4Wk_remscEnBeurtFact { get; set; }

	 public int site_L4Wk_remscFact { get; set; }

	 public int site_L4Wk_ruitwEnBeurtFact { get; set; }

	 public int site_L4Wk_ruitwFact { get; set; }

	 public int site_L4Wk_stuurEnBeurtFact { get; set; }

	 public int site_L4Wk_stuurFact { get; set; }

	 public int site_L4Wk_uitlaatEnBeurtFact { get; set; }

	 public int site_L4Wk_uitlaatFact { get; set; }

	 public double site_L4Wk_UurPerFact { get; set; }

	 public DateTime site_LaatsteMnd_DateFrom { get; set; }

	 public double site_LaatsteMnd_Budget { get; set; }

	 public int site_LaatsteMnd_Fact { get; set; }

	 public double site_LaatsteMnd_GefactureerdeUren { get; set; }

	 public double site_LaatsteMnd_Loon { get; set; }

	 public double site_LaatsteMnd_LoonPerFact { get; set; }

	 public double site_LaatsteMnd_Omzet { get; set; }

	 public double site_LaatsteMnd_OmzetMinBudget { get; set; }

	 public double site_LaatsteMnd_UurPerFact { get; set; }

	 public int site_LaatsteMnd_Werkdag { get; set; }

	 public double site_LaatsteWk_AantalLitersOlieSmeerm { get; set; }

	 public int site_LaatsteWk_accuEnBeurtFact { get; set; }

	 public int site_LaatsteWk_accuFact { get; set; }

	 public int site_LaatsteWk_remvlEnBeurtFact { get; set; }

	 public int site_LaatsteWk_remvlFact { get; set; }

	 public int site_LaatsteWk_uitlijnEnBeurtFact { get; set; }

	 public int site_LaatsteWk_uitlijnFact { get; set; }

	 public int site_LaatsteWk_pechFact { get; set; }

	 public int site_LaatsteWk_aircFact { get; set; }

	 public int site_LaatsteWk_apkFact { get; set; }

	 public int site_LaatsteWk_bandEnBeurtFact { get; set; }

	 public int site_LaatsteWk_bandFact { get; set; }

	 public int site_LaatsteWk_bougEnBeurtFact { get; set; }

	 public int site_LaatsteWk_bougFact { get; set; }

	 public int site_LaatsteWk_sproeiFact { get; set; }

	 public double site_LaatsteWk_Budget { get; set; }

	 public int site_LaatsteWk_distriEnBeurtFact { get; set; }

	 public int site_LaatsteWk_distriFact { get; set; }

	 public int site_LaatsteWk_Fact { get; set; }

	 public double site_LaatsteWk_Inkoopwaarde { get; set; }

	 public int site_LaatsteWk_intfEnBeurtFact { get; set; }

	 public int site_LaatsteWk_intfFact { get; set; }

	 public int site_LaatsteWk_kleinEnBeurtFact { get; set; }

	 public int site_LaatsteWk_kleinFact { get; set; }

	 public int site_LaatsteWk_Klok_AfwezigTotaal { get; set; }

	 public int site_LaatsteWk_Klok_BrutoUrenBeschikbaar { get; set; }

	 public int site_LaatsteWk_Klok_Cursus { get; set; }

	 public double site_LaatsteWk_Klok_Efficientie { get; set; }

	 public double site_LaatsteWk_Klok_InternGeklokt { get; set; }

	 public double site_LaatsteWk_Klok_KlantGeklokt { get; set; }

	 public double site_LaatsteWk_Klok_LoonOmzet { get; set; }

	 public double site_LaatsteWk_Klok_OmzetTotaal { get; set; }

	 public int site_LaatsteWk_Klok_NettoBeschikbaar { get; set; }

	 public int site_LaatsteWk_Klok_NettoBeschikbaarAlsMonteur { get; set; }

	 public int site_LaatsteWk_Klok_overUren { get; set; }

	 public double site_LaatsteWk_Klok_ProductiefUurloon { get; set; }

	 public double site_LaatsteWk_Klok_PrognoseUrenPerJaar { get; set; }

	 public int site_LaatsteWk_Klok_PrognUrenVerkochtPerMonteur { get; set; }

	 public int site_LaatsteWk_Klok_TrainingsdagenPerMonteur { get; set; }

	 public int site_LaatsteWk_Klok_UrenOpKlantGeklokt { get; set; }

	 public double site_LaatsteWk_Klok_UrenverkochtFact { get; set; }

	 public double site_LaatsteWk_Klok_VerantwoordDoorMonteurGeklokt { get; set; }

	 public int site_LaatsteWk_Klok_Verlof { get; set; }

	 public int site_LaatsteWk_Klok_Ziek { get; set; }

	 public int site_LaatsteWk_koelEnBeurtFact { get; set; }

	 public int site_LaatsteWk_koelFact { get; set; }

	 public double site_LaatsteWk_Loon { get; set; }

	 public double site_LaatsteWk_LoonPerFact { get; set; }

	 public int site_LaatsteWk_luchtEnBeurtFact { get; set; }

	 public int site_LaatsteWk_luchtFact { get; set; }

	 public double site_LaatsteWk_NettoMargeDelen { get; set; }

	 public int site_LaatsteWk_olieBijvulFact { get; set; }

	 public int site_LaatsteWk_oliefFact { get; set; }

	 public double site_LaatsteWk_Omzet { get; set; }

	 public double site_LaatsteWk_OmzetPerDag { get; set; }

	 public double site_LaatsteWk_OmzetApk { get; set; }

	 public double site_LaatsteWk_OmzetApkTijdensBeurt { get; set; }

	 public double site_LaatsteWk_OmzetBeurt { get; set; }

	 public double site_LaatsteWk_GemOmzetBeurt { get; set; }

	 public double site_LaatsteWk_OmzetDelen { get; set; }

	 public double site_LaatsteWk_OmzetPerFact { get; set; }

	 public int site_LaatsteWk_remblEnBeurtFact { get; set; }

	 public int site_LaatsteWk_remblFact { get; set; }

	 public int site_LaatsteWk_remscEnBeurtFact { get; set; }

	 public int site_LaatsteWk_remscFact { get; set; }

	 public int site_LaatsteWk_ruitwEnBeurtFact { get; set; }

	 public int site_LaatsteWk_ruitwFact { get; set; }

	 public int site_LaatsteWk_stuurEnBeurtFact { get; set; }

	 public int site_LaatsteWk_stuurFact { get; set; }

	 public int site_LaatsteWk_uitlaatEnBeurtFact { get; set; }

	 public int site_LaatsteWk_uitlaatFact { get; set; }

	 public int site_LaatsteWk_Werkdagen { get; set; }

	 public string site_LaatsteWk_DateFrom { get; set; }

	 public string site_LaatsteWk_DateTo { get; set; }

	 public int site_LaatsteWk_factLosseApk { get; set; }

	 public double site_LaatsteWk_Klok_OmzetPerMonteurPrognose { get; set; }

	 public double site_Lyfull_Omzet { get; set; }

	 public double site_Lytd_Omzet { get; set; }

	 public double site_Lytd_OmzetPerFact { get; set; }

	 public double site_Lytd_OmzetPerFact_Land { get; set; }

	 public double site_Ytd_Budget { get; set; }

	 public double site_Ytd_BudgetPerDag { get; set; }

	 public int site_Ytd_Klanten { get; set; }

	 public double site_Ytd_Klok_OmzetTotaal { get; set; }

	 public double site_Ytd_Klok_AantalMonteurs { get; set; }

	 public double site_Ytd_Klok_AfwezigTotaal { get; set; }

	 public int site_Ytd_Klok_BrutoUrenBeschikbaar { get; set; }

	 public int site_Ytd_Klok_Cursus { get; set; }

	 public double site_Ytd_Klok_Efficientie { get; set; }

	 public double site_Ytd_Klok_InternGeklokt { get; set; }

	 public double site_Ytd_Klok_KlantGeklokt { get; set; }

	 public double site_Ytd_Klok_NettoBeschikbaar { get; set; }

	 public double site_Ytd_Klok_NettoBeschikbaarAlsMonteur { get; set; }

	 public double site_Ytd_Klok_OmzetPerMonteurPrognose { get; set; }

	 public int site_Ytd_Klok_overUren { get; set; }

	 public double site_Ytd_Klok_ProductiefUurloon { get; set; }

	 public double site_Ytd_Klok_PrognoseUrenPerJaar { get; set; }

	 public int site_Ytd_Klok_PrognUrenVerkochtPerMonteur { get; set; }

	 public double site_Ytd_Klok_TrainingsdagenPerMonteur { get; set; }

	 public int site_Ytd_Klok_UrenOpKlantGeklokt { get; set; }

	 public double site_Ytd_Klok_UrenverkochtFact { get; set; }

	 public double site_Ytd_Klok_VerantwoordDoorMonteurGeklokt { get; set; }

	 public double site_Ytd_Klok_Verlof { get; set; }

	 public int site_Ytd_Klok_Ziek { get; set; }

	 public double site_Ytd_Loon { get; set; }

	 public double site_Ytd_LoonPerFact { get; set; }

	 public double site_Ytd_NettoOmzet { get; set; }

	 public double site_Ytd_Omzet { get; set; }

	 public double site_Ytd_OmzetMinBudget { get; set; }

	 public double site_Ytd_OmzetPerDag { get; set; }

	 public double site_Ytd_OmzetPerFact { get; set; }

	 public double site_Ytd_OmzetPerFact_Land { get; set; }

	 public double site_Ytd_OmzetVerschilVorigJaar { get; set; }

	 public int site_Ytd_Werkdagen { get; set; }

	 public double site_L12Mnd_accuEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_accuEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_accuFact_Land_Prc { get; set; }

	 public double site_L12Mnd_accuFact_Prc { get; set; }

	 public double site_L12Mnd_accuVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_accuVervang_Prc { get; set; }

	 public double site_L12Mnd_accuVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_aircEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_aircEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_aircFact_Land_Prc { get; set; }

	 public double site_L12Mnd_aircFact_Prc { get; set; }

	 public double site_L12Mnd_aircVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_aircVervang_Prc { get; set; }

	 public double site_L12Mnd_aircVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_bandEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_bandEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_bandFact_Land_Prc { get; set; }

	 public double site_L12Mnd_bandFact_Prc { get; set; }

	 public double site_L12Mnd_bandVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_bandVervang_Prc { get; set; }

	 public double site_L12Mnd_bandVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_bougEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_bougEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_bougFact_Land_Prc { get; set; }

	 public double site_L12Mnd_bougFact_Prc { get; set; }

	 public double site_L12Mnd_bougVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_bougVervang_Prc { get; set; }

	 public double site_L12Mnd_bougVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_distriEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_distriEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_distriFact_Land_Prc { get; set; }

	 public double site_L12Mnd_distriFact_Prc { get; set; }

	 public double site_L12Mnd_distriVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_distriVervang_Prc { get; set; }

	 public double site_L12Mnd_distriVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_intfEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_intfEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_intfFact_Land_Prc { get; set; }

	 public double site_L12Mnd_intfFact_Prc { get; set; }

	 public double site_L12Mnd_intfVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_intfVervang_Prc { get; set; }

	 public double site_L12Mnd_intfVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_kleinEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_kleinEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_kleinFact_Land_Prc { get; set; }

	 public double site_L12Mnd_kleinFact_Prc { get; set; }

	 public double site_L12Mnd_kleinVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_kleinVervang_Prc { get; set; }

	 public double site_L12Mnd_kleinVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_koelEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_koelEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_koelFact_Land_Prc { get; set; }

	 public double site_L12Mnd_koelFact_Prc { get; set; }

	 public double site_L12Mnd_koelVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_koelVervang_Prc { get; set; }

	 public double site_L12Mnd_koelVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_luchtEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_luchtEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_luchtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_luchtFact_Prc { get; set; }

	 public double site_L12Mnd_luchtVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_luchtVervang_Prc { get; set; }

	 public double site_L12Mnd_luchtVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_oliefFact_Land_Prc { get; set; }

	 public double site_L12Mnd_oliefFact_Prc { get; set; }

	 public double site_L12Mnd_oliefVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_oliefVervang_Prc { get; set; }

	 public double site_L12Mnd_oliefVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_pechEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_pechEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_pechFact_Land_Prc { get; set; }

	 public double site_L12Mnd_pechFact_Prc { get; set; }

	 public double site_L12Mnd_pechVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_pechVervang_Prc { get; set; }

	 public double site_L12Mnd_pechVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_remblEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_remblEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_remblFact_Land_Prc { get; set; }

	 public double site_L12Mnd_remblFact_Prc { get; set; }

	 public double site_L12Mnd_remblVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_remblVervang_Prc { get; set; }

	 public double site_L12Mnd_remblVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_remscEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_remscEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_remscFact_Land_Prc { get; set; }

	 public double site_L12Mnd_remscFact_Prc { get; set; }

	 public double site_L12Mnd_remscVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_remscVervang_Prc { get; set; }

	 public double site_L12Mnd_remscVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_remvlEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_remvlEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_remvlFact_Land_Prc { get; set; }

	 public double site_L12Mnd_remvlFact_Prc { get; set; }

	 public double site_L12Mnd_remvlVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_remvlVervang_Prc { get; set; }

	 public double site_L12Mnd_remvlVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_ruitwEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_ruitwEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_ruitwFact_Land_Prc { get; set; }

	 public double site_L12Mnd_ruitwFact_Prc { get; set; }

	 public double site_L12Mnd_ruitwVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_ruitwVervang_Prc { get; set; }

	 public double site_L12Mnd_ruitwVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_sproeiEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_sproeiEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_sproeiFact_Land_Prc { get; set; }

	 public double site_L12Mnd_sproeiFact_Prc { get; set; }

	 public double site_L12Mnd_sproeiVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_sproeiVervang_Prc { get; set; }

	 public double site_L12Mnd_sproeiVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_stuurEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_stuurEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_stuurFact_Land_Prc { get; set; }

	 public double site_L12Mnd_stuurFact_Prc { get; set; }

	 public double site_L12Mnd_stuurVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_stuurVervang_Prc { get; set; }

	 public double site_L12Mnd_stuurVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_uitlaatEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_uitlaatEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_uitlaatFact_Land_Prc { get; set; }

	 public double site_L12Mnd_uitlaatFact_Prc { get; set; }

	 public double site_L12Mnd_uitlaatVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_uitlaatVervang_Prc { get; set; }

	 public double site_L12Mnd_uitlaatVervang_Top100_Prc { get; set; }

	 public double site_L12Mnd_uitlijnEnBeurtFact_Land_Prc { get; set; }

	 public double site_L12Mnd_uitlijnEnBeurtFact_Prc { get; set; }

	 public double site_L12Mnd_uitlijnFact_Land_Prc { get; set; }

	 public double site_L12Mnd_uitlijnFact_Prc { get; set; }

	 public double site_L12Mnd_uitlijnVervang_Land_Prc { get; set; }

	 public double site_L12Mnd_uitlijnVervang_Prc { get; set; }

	 public double site_L12Mnd_uitlijnVervang_Top100_Prc { get; set; }

	 public double site_L12Wk_Klok_Bezettingsgraad_Prc { get; set; }

	 public double site_L12Wk_Klok_BezettingsgraadWo_Prc { get; set; }

	 public double site_L12Wk_Klok_Efficientie_Prc { get; set; }

	 public double site_L12Wk_Klok_Productiviteit_Prc { get; set; }

	 public double site_L12Wk_Klok_UrenOpKlantGeklokt_Prc { get; set; }

	 public double site_L12Wk_Klok_Ziekteverzuim_Prc { get; set; }

	 public double site_L4Wk_accuEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_accuEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_accuFact_Land_Prc { get; set; }

	 public double site_L4Wk_accuFact_Prc { get; set; }

	 public double site_L4Wk_bandEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_bandEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_bandFact_Land_Prc { get; set; }

	 public double site_L4Wk_bandFact_Prc { get; set; }

	 public double site_L4Wk_bougEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_bougEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_bougFact_Land_Prc { get; set; }

	 public double site_L4Wk_bougFact_Prc { get; set; }

	 public double site_L4Wk_distriEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_distriEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_distriFact_Land_Prc { get; set; }

	 public double site_L4Wk_distriFact_Prc { get; set; }

	 public double site_L4Wk_intfEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_intfEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_intfFact_Land_Prc { get; set; }

	 public double site_L4Wk_intfFact_Prc { get; set; }

	 public double site_L4Wk_kleinEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_kleinEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_kleinFact_Land_Prc { get; set; }

	 public double site_L4Wk_kleinFact_Prc { get; set; }

	 public double site_L4Wk_koelEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_koelEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_koelFact_Land_Prc { get; set; }

	 public double site_L4Wk_koelFact_Prc { get; set; }

	 public double site_L4Wk_LoonDelen_Land_Prc { get; set; }

	 public double site_L4Wk_LoonDelen_LandLy_Prc { get; set; }

	 public double site_L4Wk_LoonDelen_Prc { get; set; }

	 public double site_L4Wk_luchtEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_luchtEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_luchtFact_Land_Prc { get; set; }

	 public double site_L4Wk_luchtFact_Prc { get; set; }

	 public double site_L4Wk_oliefFact_Land_Prc { get; set; }

	 public double site_L4Wk_oliefFact_Prc { get; set; }

	 public double site_L4Wk_OmzetPerFact_SiteVersusLand_Prc { get; set; }

	 public double site_L4Wk_remblEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_remblEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_remblFact_Land_Prc { get; set; }

	 public double site_L4Wk_remblFact_Prc { get; set; }

	 public double site_L4Wk_remscEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_remscEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_remscFact_Land_Prc { get; set; }

	 public double site_L4Wk_remscFact_Prc { get; set; }

	 public double site_L4Wk_ruitwEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_ruitwEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_ruitwFact_Land_Prc { get; set; }

	 public double site_L4Wk_ruitwFact_Prc { get; set; }

	 public double site_L4Wk_stuurEnBeurtFact_Land_Prc { get; set; }

	 public double site_L4Wk_stuurEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_stuurFact_Land_Prc { get; set; }

	 public double site_L4Wk_stuurFact_Prc { get; set; }

	 public double site_L4Wk_uitlaatEnBeurtFact_Prc { get; set; }

	 public double site_L4Wk_uitlaatFact_Land_Prc { get; set; }

	 public double site_L4Wk_uitlaatFact_Prc { get; set; }

	 public double site_LaatsteMnd_LoonPerFact_Prc { get; set; }

	 public double site_LaatsteMnd_OmzetBudget_Prc { get; set; }

	 public double site_LaatsteWk_accuEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_accuEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_accuFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_accuFact_Prc { get; set; }

	 public double site_LaatsteWk_uitlijnEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_uitlijnEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_uitlijnFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_uitlijnFact_Prc { get; set; }

	 public double site_LaatsteWk_remvlEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_remvlEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_remvlFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_remvlFact_Prc { get; set; }

	 public double site_LaatsteWk_pechEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_pechEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_pechFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_pechFact_Prc { get; set; }

	 public double site_LaatsteWk_aircEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_aircEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_aircFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_aircFact_Prc { get; set; }

	 public double site_LaatsteWk_sproeiEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_sproeiEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_sproeiFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_sproeiFact_Prc { get; set; }

	 public double site_LaatsteWk_bandEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_bandEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_bandFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_bandFact_Prc { get; set; }

	 public double site_LaatsteWk_bougEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_bougEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_bougFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_bougFact_Prc { get; set; }

	 public double site_LaatsteWk_BrutoMarge_Prc { get; set; }

	 public double site_LaatsteWk_distriEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_distriEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_distriFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_distriFact_Prc { get; set; }

	 public double site_LaatsteWk_intfEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_intfEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_intfFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_intfFact_Prc { get; set; }

	 public double site_LaatsteWk_kleinEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_kleinEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_kleinFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_kleinFact_Prc { get; set; }

	 public double site_LaatsteWk_Klok_Bezettingsgraad_Prc { get; set; }

	 public double site_LaatsteWk_Klok_BezettingsgraadWo_Prc { get; set; }

	 public double site_LaatsteWk_Klok_Efficientie_Prc { get; set; }

	 public double site_LaatsteWk_Klok_Productiviteit_Prc { get; set; }

	 public double site_LaatsteWk_Klok_UrenOpKlantGeklokt_Prc { get; set; }

	 public double site_LaatsteWk_Klok_Ziekteverzuim_Prc { get; set; }

	 public double site_LaatsteWk_koelEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_koelEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_koelFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_koelFact_Prc { get; set; }

	 public double site_LaatsteWk_LoonDelen_Prc { get; set; }

	 public double site_LaatsteWk_luchtEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_luchtEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_luchtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_luchtFact_Prc { get; set; }

	 public double site_LaatsteWk_NettoMargeDelen_Prc { get; set; }

	 public double site_LaatsteWk_oliefFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_oliefFact_Prc { get; set; }

	 public double site_LaatsteWk_OmzetBudget_Prc { get; set; }

	 public double site_LaatsteWk_remblEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_remblEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_remblFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_remblFact_Prc { get; set; }

	 public double site_LaatsteWk_remscEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_remscEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_remscFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_remscFact_Prc { get; set; }

	 public double site_LaatsteWk_ruitwEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_ruitwEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_ruitwFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_ruitwFact_Prc { get; set; }

	 public double site_LaatsteWk_stuurEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_stuurEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_stuurFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_stuurFact_Prc { get; set; }

	 public double site_LaatsteWk_uitlaatEnBeurtFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_uitlaatEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteWk_uitlaatFact_Land_Prc { get; set; }

	 public double site_LaatsteWk_uitlaatFact_Prc { get; set; }

	 public double site_Lytd_BrutoMarge_Prc { get; set; }

	 public double site_Lytd_NettoMargeDelen_Prc { get; set; }

	 public double site_Lytd_OmzetPerFact_SiteVersusLand_Prc { get; set; }

	 public double site_Ytd_BrutoMarge_Prc { get; set; }

	 public double site_Ytd_Klok_Bezettingsgraad_Prc { get; set; }

	 public double site_Ytd_Klok_BezettingsgraadWo_Prc { get; set; }

	 public double site_Ytd_Klok_Efficientie_Prc { get; set; }

	 public double site_Ytd_Klok_ExternIntern_Prc { get; set; }

	 public double site_Ytd_Klok_Productiviteit_Prc { get; set; }

	 public double site_Ytd_Klok_UrenOpKlantGeklokt_Prc { get; set; }

	 public double site_Ytd_Klok_Ziekteverzuim_Prc { get; set; }

	 public double site_Ytd_LoonDelen_Prc { get; set; }

	 public double site_Ytd_NettoMargeDelen_Prc { get; set; }

	 public double site_Ytd_OmzetBudget_Prc { get; set; }

	 public double site_Ytd_OmzetMetInkoopwaarde_Prc { get; set; }

	 public double site_Ytd_OmzetPerFact_SiteVersusLand_Prc { get; set; }

	 public int site_LaatsteMnd_accuFact { get; set; }

	 public double site_LaatsteMnd_accuFact_Prc { get; set; }

	 public double site_LaatsteMnd_accuFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_accuEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_accuEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_aircFact { get; set; }

	 public double site_LaatsteMnd_aircFact_Prc { get; set; }

	 public double site_LaatsteMnd_aircFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_aircEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_aircEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_bandFact { get; set; }

	 public double site_LaatsteMnd_bandFact_Prc { get; set; }

	 public double site_LaatsteMnd_bandFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_bandEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_bandEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_bougFact { get; set; }

	 public double site_LaatsteMnd_bougFact_Prc { get; set; }

	 public double site_LaatsteMnd_bougFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_bougEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_bougEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_distriFact { get; set; }

	 public double site_LaatsteMnd_distriFact_Prc { get; set; }

	 public double site_LaatsteMnd_distriFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_distriEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_distriEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_intfFact { get; set; }

	 public double site_LaatsteMnd_intfFact_Prc { get; set; }

	 public double site_LaatsteMnd_intfFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_intfEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_intfEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_kleinFact { get; set; }

	 public double site_LaatsteMnd_kleinFact_Prc { get; set; }

	 public double site_LaatsteMnd_kleinFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_kleinEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_kleinEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_koelFact { get; set; }

	 public double site_LaatsteMnd_koelFact_Prc { get; set; }

	 public double site_LaatsteMnd_koelFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_koelEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_koelEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_luchtFact { get; set; }

	 public double site_LaatsteMnd_luchtFact_Prc { get; set; }

	 public double site_LaatsteMnd_luchtFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_luchtEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_luchtEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_remblFact { get; set; }

	 public double site_LaatsteMnd_remblFact_Prc { get; set; }

	 public double site_LaatsteMnd_remblFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_remblEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_remblEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_remscFact { get; set; }

	 public double site_LaatsteMnd_remscFact_Prc { get; set; }

	 public double site_LaatsteMnd_remscFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_remscEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_remscEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_remvlFact { get; set; }

	 public double site_LaatsteMnd_remvlFact_Prc { get; set; }

	 public double site_LaatsteMnd_remvlFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_remvlEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_remvlEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_ruitwFact { get; set; }

	 public double site_LaatsteMnd_ruitwFact_Prc { get; set; }

	 public double site_LaatsteMnd_ruitwFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_ruitwEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_ruitwEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_stuurFact { get; set; }

	 public double site_LaatsteMnd_stuurFact_Prc { get; set; }

	 public double site_LaatsteMnd_stuurFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_stuurEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_stuurEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_uitlaatFact { get; set; }

	 public double site_LaatsteMnd_uitlaatFact_Prc { get; set; }

	 public double site_LaatsteMnd_uitlaatFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_uitlaatEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_uitlaatEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_uitlijnFact { get; set; }

	 public double site_LaatsteMnd_uitlijnFact_Prc { get; set; }

	 public double site_LaatsteMnd_uitlijnFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_uitlijnEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_uitlijnEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_sproeiFact { get; set; }

	 public double site_LaatsteMnd_sproeiFact_Prc { get; set; }

	 public double site_LaatsteMnd_sproeiFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_sproeiEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_sproeiEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_pechFact { get; set; }

	 public double site_LaatsteMnd_pechFact_Prc { get; set; }

	 public double site_LaatsteMnd_pechFact_Land_Prc { get; set; }

	 public double site_LaatsteMnd_pechEnBeurtFact_Prc { get; set; }

	 public double site_LaatsteMnd_pechEnBeurtFact_Land_Prc { get; set; }

	 public int site_LaatsteMnd_oliefFact { get; set; }

	 public double site_LaatsteMnd_oliefFact_Prc { get; set; }

	 public double site_LaatsteMnd_oliefFact_Land_Prc { get; set; }

	 public int rp31_instroom { get; set; }

	 public int rp31_uitstroom { get; set; }

	 public double site_L12Wk_remvlEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_remvlEnBeurt_Prc { get; set; }

	 public int site_L12Wk_remvlFact { get; set; }

	 public double site_L12Wk_remvlFact_Land_Prc { get; set; }

	 public double site_L12Wk_remvlFact_Prc { get; set; }

	 public double site_L12Wk_aircEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_aircEnBeurt_Prc { get; set; }

	 public int site_L12Wk_aircFact { get; set; }

	 public double site_L12Wk_aircFact_Land_Prc { get; set; }

	 public double site_L12Wk_aircFact_Prc { get; set; }

	 public double site_L12Wk_pechEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_pechEnBeurt_Prc { get; set; }

	 public int site_L12Wk_pechFact { get; set; }

	 public double site_L12Wk_pechFact_Land_Prc { get; set; }

	 public double site_L12Wk_pechFact_Prc { get; set; }

	 public double site_L12Wk_accuEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_sproeiEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_sproeiEnBeurt_Prc { get; set; }

	 public double site_L12Wk_accuEnBeurt_Prc { get; set; }

	 public int site_L12Wk_accuFact { get; set; }

	 public double site_L12Wk_accuFact_Land_Prc { get; set; }

	 public double site_L12Wk_accuFact_Prc { get; set; }

	 public int site_L12Wk_sproeiFact { get; set; }

	 public double site_L12Wk_sproeiFact_Land_Prc { get; set; }

	 public double site_L12Wk_sproeiFact_Prc { get; set; }

	 public double site_L12Wk_bandEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_bandEnBeurt_Prc { get; set; }

	 public int site_L12Wk_bandFact { get; set; }

	 public double site_L12Wk_bandFact_Land_Prc { get; set; }

	 public double site_L12Wk_bandFact_Prc { get; set; }

	 public double site_L12Wk_bougEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_bougEnBeurt_Prc { get; set; }

	 public int site_L12Wk_bougFact { get; set; }

	 public double site_L12Wk_bougFact_Land_Prc { get; set; }

	 public double site_L12Wk_bougFact_Prc { get; set; }

	 public double site_L12Wk_distriEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_distriEnBeurt_Prc { get; set; }

	 public int site_L12Wk_distriFact { get; set; }

	 public double site_L12Wk_distriFact_Land_Prc { get; set; }

	 public double site_L12Wk_distriFact_Prc { get; set; }

	 public int site_L12Wk_Fact { get; set; }

	 public double site_L12Wk_intfEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_intfEnBeurt_Prc { get; set; }

	 public int site_L12Wk_intfFact { get; set; }

	 public double site_L12Wk_intfFact_Land_Prc { get; set; }

	 public double site_L12Wk_intfFact_Prc { get; set; }

	 public double site_L12Wk_kleinEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_kleinEnBeurt_Prc { get; set; }

	 public int site_L12Wk_kleinFact { get; set; }

	 public double site_L12Wk_kleinFact_Land_Prc { get; set; }

	 public double site_L12Wk_kleinFact_Prc { get; set; }

	 public double site_L12Wk_koelEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_koelEnBeurt_Prc { get; set; }

	 public int site_L12Wk_koelFact { get; set; }

	 public double site_L12Wk_koelFact_Land_Prc { get; set; }

	 public double site_L12Wk_koelFact_Prc { get; set; }

	 public double site_L12Wk_luchtEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_luchtEnBeurt_Prc { get; set; }

	 public int site_L12Wk_luchtFact { get; set; }

	 public double site_L12Wk_luchtFact_Land_Prc { get; set; }

	 public double site_L12Wk_luchtFact_Prc { get; set; }

	 public int site_L12Wk_oliefFact { get; set; }

	 public double site_L12Wk_oliefFact_Land_Prc { get; set; }

	 public double site_L12Wk_oliefFact_Prc { get; set; }

	 public double site_L12Wk_remblEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_remblEnBeurt_Prc { get; set; }

	 public int site_L12Wk_remblFact { get; set; }

	 public double site_L12Wk_remblFact_Land_Prc { get; set; }

	 public double site_L12Wk_remblFact_Prc { get; set; }

	 public double site_L12Wk_remscEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_remscEnBeurt_Prc { get; set; }

	 public int site_L12Wk_remscFact { get; set; }

	 public double site_L12Wk_remscFact_Land_Prc { get; set; }

	 public double site_L12Wk_remscFact_Prc { get; set; }

	 public double site_L12Wk_ruitwEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_ruitwEnBeurt_Prc { get; set; }

	 public int site_L12Wk_ruitwFact { get; set; }

	 public double site_L12Wk_ruitwFact_Land_Prc { get; set; }

	 public double site_L12Wk_ruitwFact_Prc { get; set; }

	 public double site_L12Wk_stuurEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_stuurEnBeurt_Prc { get; set; }

	 public int site_L12Wk_stuurFact { get; set; }

	 public double site_L12Wk_stuurFact_Land_Prc { get; set; }

	 public double site_L12Wk_stuurFact_Prc { get; set; }

	 public double site_L12Wk_uitlaatEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_uitlaatEnBeurt_Prc { get; set; }

	 public int site_L12Wk_uitlaatFact { get; set; }

	 public double site_L12Wk_uitlaatFact_Land_Prc { get; set; }

	 public double site_L12Wk_uitlaatFact_Prc { get; set; }

	 public double site_L12Wk_uitlijnEnBeurt_Land_Prc { get; set; }

	 public double site_L12Wk_uitlijnEnBeurt_Prc { get; set; }

	 public int site_L12Wk_uitlijnFact { get; set; }

	 public double site_L12Wk_uitlijnFact_Land_Prc { get; set; }

	 public double site_L12Wk_uitlijnFact_Prc { get; set; }

	 public int site_L12Wk_accu_KentRank { get; set; }

	 public int site_L12Wk_sproei_KentRank { get; set; }

	 public int site_L12Wk_airc_KentRank { get; set; }

	 public int site_L12Wk_band_KentRank { get; set; }

	 public int site_L12Wk_boug_KentRank { get; set; }

	 public int site_L12Wk_distri_KentRank { get; set; }

	 public int site_L12Wk_intf_KentRank { get; set; }

	 public int site_L12Wk_klein_KentRank { get; set; }

	 public int site_L12Wk_koel_KentRank { get; set; }

	 public int site_L12Wk_lucht_KentRank { get; set; }

	 public int site_L12Wk_olief_KentRank { get; set; }

	 public int site_L12Wk_pech_KentRank { get; set; }

	 public int site_L12Wk_rembl_KentRank { get; set; }

	 public int site_L12Wk_remsc_KentRank { get; set; }

	 public int site_L12Wk_remvl_KentRank { get; set; }

	 public int site_L12Wk_ruitw_KentRank { get; set; }

	 public int site_L12Wk_stuur_KentRank { get; set; }

	 public int site_L12Wk_uitlaat_KentRank { get; set; }

	 public int site_L12Wk_uitlijn_KentRank { get; set; }

}
