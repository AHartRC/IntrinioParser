﻿namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;
	#endregion

	internal interface IBloggerRating : IBaseModel
	{
		DateTime? Date { get; set; }
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string Sector { get; set; }
		int? BlogID { get; set; }
		int? BloggerID { get; set; }
		RecommendationRating Rating { get; set; }
		string Source { get; set; }
	}
}