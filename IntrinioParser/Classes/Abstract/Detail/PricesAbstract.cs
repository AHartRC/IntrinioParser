namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class PricesAbstract
		: BaseAbstract,
		  IPrices
	{
		internal PricesAbstract()
		{
			DataType = IntrinioDataType.Prices;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IPrices
		[JsonProperty("")]
		public DateTime? Date { get; set; }

		[JsonProperty("")]
		public decimal? Open { get; set; }

		[JsonProperty("")]
		public decimal? High { get; set; }

		[JsonProperty("")]
		public decimal? Low { get; set; }

		[JsonProperty("")]
		public decimal? Close { get; set; }

		[JsonProperty("")]
		public long Volume { get; set; }

		[JsonProperty("")]
		public decimal? ExDividend { get; set; }

		[JsonProperty("")]
		public decimal? SplitRatio { get; set; }

		[JsonProperty("")]
		public decimal? AdjOpen { get; set; }

		[JsonProperty("")]
		public decimal? AdjHigh { get; set; }

		[JsonProperty("")]
		public decimal? AdjLow { get; set; }

		[JsonProperty("")]
		public decimal? AdjClose { get; set; }

		[JsonProperty("")]
		public long AdjVolume { get; set; }
		#endregion
	}
}