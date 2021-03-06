﻿namespace IntrinioParser.Mapping.CSV.Master
{
	#region
	using CsvHelper.Configuration;

	using Models.Binding.Master;
	#endregion

	internal sealed class StockExchangeMasterCSVMap : ClassMap<StockExchangeMaster>
	{
		internal StockExchangeMasterCSVMap()
		{
			Map(m => m.Symbol)
				.Name("SYMBOL")
				.NameIndex(0)
				.Default(null);
			Map(m => m.MIC)
				.Name("MIC")
				.NameIndex(0)
				.Default(null);
			Map(m => m.InstitutionName)
				.Name("INSTITUTION_NAME")
				.NameIndex(0)
				.Default(null);
			Map(m => m.Acronym)
				.Name("ACRONYM")
				.NameIndex(0)
				.Default(null);
			Map(m => m.City)
				.Name("CITY")
				.NameIndex(0)
				.Default(null);
			Map(m => m.Country)
				.Name("COUNTRY")
				.NameIndex(0)
				.Default(null);
			Map(m => m.CountryCode)
				.Name("COUNTRY_CODE")
				.NameIndex(0)
				.Default(null);
			Map(m => m.Website)
				.Name("WEBSITE")
				.NameIndex(0)
				.Default(null);
		}
	}
}