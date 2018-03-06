﻿namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System.ComponentModel.DataAnnotations.Schema;

	using Attributes;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Master;

	using Newtonsoft.Json;
	#endregion

	internal abstract class CompanyAbstract
		: BaseAbstract,
		  ICompany
	{
		internal CompanyAbstract()
		{
			DataType = IntrinioDataType.Companies;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of ICompanyMasterable
		[ForeignKey("CompanyMaster")]
		public int CompanyMasterID { get; set; }

		[Hidden]
		public virtual CompanyMaster CompanyMaster { get; set; }
		#endregion

		#region Implementation of ICompany
		[JsonProperty("ticker")]
		public string Ticker { get; set; }

		[JsonProperty("cik")]
		public string CIK { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("legal_name")]
		public string LegalName { get; set; }

		[JsonProperty("lei")]
		public string LEI { get; set; }

		[JsonProperty("hq_address1")]
		public string HQAddress1 { get; set; }

		[JsonProperty("hq_address2")]
		public string HQAddress2 { get; set; }

		[JsonProperty("hq_address_city")]
		public string HQAddressCity { get; set; }

		[JsonProperty("hq_address_postal_code")]
		public string HQAddressPostalCode { get; set; }

		[JsonProperty("entity_legal_form")]
		public string EntityLegalForm { get; set; }

		[JsonProperty("hq_state")]
		public string HQState { get; set; }

		[JsonProperty("hq_country")]
		public string HQCountry { get; set; }

		[JsonProperty("inc_state")]
		public string IncState { get; set; }

		[JsonProperty("inc_country")]
		public string IncCountry { get; set; }

		[JsonProperty("sic")]
		public string SIC { get; set; }

		[JsonProperty("stock_exchange")]
		public string StockExchange { get; set; }

		[JsonProperty("template")]
		public string Template { get; set; }

		[JsonProperty("short_description")]
		public string ShortDescription { get; set; }

		[JsonProperty("long_description")]
		public string LongDescription { get; set; }

		[JsonProperty("ceo")]
		public string CEO { get; set; }

		[JsonProperty("company_url")]
		public string CompanyURL { get; set; }

		[JsonProperty("business_address")]
		public string BusinessAddress { get; set; }

		[JsonProperty("mailing_address")]
		public string MailingAddress { get; set; }

		[JsonProperty("business_phone_no")]
		public string BusinessPhoneNo { get; set; }

		[JsonProperty("employees")]
		public int? Employees { get; set; }

		[JsonProperty("sector")]
		public string Sector { get; set; }

		[JsonProperty("industry_category")]
		public string IndustryCategory { get; set; }

		[JsonProperty("industry_group")]
		public string IndustryGroup { get; set; }

		[JsonProperty("standardized_active")]
		public bool? StandardizedActive { get; set; }
		#endregion
	}
}