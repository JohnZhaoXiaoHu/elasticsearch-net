// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.QueryDsl;

public sealed partial class SimpleQueryStringQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }
	[JsonInclude, JsonPropertyName("analyze_wildcard")]
	public bool? AnalyzeWildcard { get; set; }
	[JsonInclude, JsonPropertyName("analyzer")]
	public string? Analyzer { get; set; }
	[JsonInclude, JsonPropertyName("auto_generate_synonyms_phrase_query")]
	public bool? AutoGenerateSynonymsPhraseQuery { get; set; }
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }
	[JsonInclude, JsonPropertyName("default_operator")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get; set; }
	[JsonInclude, JsonPropertyName("fields")]
	public Fields? Fields { get; set; }
	[JsonInclude, JsonPropertyName("fuzzy_max_expansions")]
	public int? FuzzyMaxExpansions { get; set; }
	[JsonInclude, JsonPropertyName("fuzzy_prefix_length")]
	public int? FuzzyPrefixLength { get; set; }
	[JsonInclude, JsonPropertyName("fuzzy_transpositions")]
	public bool? FuzzyTranspositions { get; set; }
	[JsonInclude, JsonPropertyName("lenient")]
	public bool? Lenient { get; set; }
	[JsonInclude, JsonPropertyName("minimum_should_match")]
	public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }
	[JsonInclude, JsonPropertyName("query")]
	public string Query { get; set; }
	[JsonInclude, JsonPropertyName("quote_field_suffix")]
	public string? QuoteFieldSuffix { get; set; }

	public static implicit operator Query(SimpleQueryStringQuery simpleQueryStringQuery) => QueryDsl.Query.SimpleQueryString(simpleQueryStringQuery);

	internal override void InternalWrapInContainer(Query container) => container.WrapVariant("simple_query_string", this);
}

public sealed partial class SimpleQueryStringQueryDescriptor<TDocument> : SerializableDescriptor<SimpleQueryStringQueryDescriptor<TDocument>>
{
	internal SimpleQueryStringQueryDescriptor(Action<SimpleQueryStringQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SimpleQueryStringQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }
	private bool? AnalyzeWildcardValue { get; set; }
	private string? AnalyzerValue { get; set; }
	private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperatorValue { get; set; }
	private Fields? FieldsValue { get; set; }
	private int? FuzzyMaxExpansionsValue { get; set; }
	private int? FuzzyPrefixLengthValue { get; set; }
	private bool? FuzzyTranspositionsValue { get; set; }
	private bool? LenientValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private string QueryValue { get; set; }
	private string? QuoteFieldSuffixValue { get; set; }

	public SimpleQueryStringQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> AnalyzeWildcard(bool? analyzeWildcard = true)
	{
		AnalyzeWildcardValue = analyzeWildcard;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
	{
		AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator)
	{
		DefaultOperatorValue = defaultOperator;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> Fields(Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> FuzzyMaxExpansions(int? fuzzyMaxExpansions)
	{
		FuzzyMaxExpansionsValue = fuzzyMaxExpansions;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> FuzzyPrefixLength(int? fuzzyPrefixLength)
	{
		FuzzyPrefixLengthValue = fuzzyPrefixLength;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true)
	{
		FuzzyTranspositionsValue = fuzzyTranspositions;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> Lenient(bool? lenient = true)
	{
		LenientValue = lenient;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor<TDocument> QuoteFieldSuffix(string? quoteFieldSuffix)
	{
		QuoteFieldSuffixValue = quoteFieldSuffix;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (AnalyzeWildcardValue.HasValue)
		{
			writer.WritePropertyName("analyze_wildcard");
			writer.WriteBooleanValue(AnalyzeWildcardValue.Value);
		}

		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
		{
			writer.WritePropertyName("auto_generate_synonyms_phrase_query");
			writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (DefaultOperatorValue is not null)
		{
			writer.WritePropertyName("default_operator");
			JsonSerializer.Serialize(writer, DefaultOperatorValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (FuzzyMaxExpansionsValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_max_expansions");
			writer.WriteNumberValue(FuzzyMaxExpansionsValue.Value);
		}

		if (FuzzyPrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_prefix_length");
			writer.WriteNumberValue(FuzzyPrefixLengthValue.Value);
		}

		if (FuzzyTranspositionsValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_transpositions");
			writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
		}

		if (LenientValue.HasValue)
		{
			writer.WritePropertyName("lenient");
			writer.WriteBooleanValue(LenientValue.Value);
		}

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(QuoteFieldSuffixValue))
		{
			writer.WritePropertyName("quote_field_suffix");
			writer.WriteStringValue(QuoteFieldSuffixValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SimpleQueryStringQueryDescriptor : SerializableDescriptor<SimpleQueryStringQueryDescriptor>
{
	internal SimpleQueryStringQueryDescriptor(Action<SimpleQueryStringQueryDescriptor> configure) => configure.Invoke(this);

	public SimpleQueryStringQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }
	private bool? AnalyzeWildcardValue { get; set; }
	private string? AnalyzerValue { get; set; }
	private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperatorValue { get; set; }
	private Fields? FieldsValue { get; set; }
	private int? FuzzyMaxExpansionsValue { get; set; }
	private int? FuzzyPrefixLengthValue { get; set; }
	private bool? FuzzyTranspositionsValue { get; set; }
	private bool? LenientValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private string QueryValue { get; set; }
	private string? QuoteFieldSuffixValue { get; set; }

	public SimpleQueryStringQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor AnalyzeWildcard(bool? analyzeWildcard = true)
	{
		AnalyzeWildcardValue = analyzeWildcard;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
	{
		AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator)
	{
		DefaultOperatorValue = defaultOperator;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor Fields(Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor FuzzyMaxExpansions(int? fuzzyMaxExpansions)
	{
		FuzzyMaxExpansionsValue = fuzzyMaxExpansions;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor FuzzyPrefixLength(int? fuzzyPrefixLength)
	{
		FuzzyPrefixLengthValue = fuzzyPrefixLength;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor FuzzyTranspositions(bool? fuzzyTranspositions = true)
	{
		FuzzyTranspositionsValue = fuzzyTranspositions;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor Lenient(bool? lenient = true)
	{
		LenientValue = lenient;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public SimpleQueryStringQueryDescriptor QuoteFieldSuffix(string? quoteFieldSuffix)
	{
		QuoteFieldSuffixValue = quoteFieldSuffix;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (AnalyzeWildcardValue.HasValue)
		{
			writer.WritePropertyName("analyze_wildcard");
			writer.WriteBooleanValue(AnalyzeWildcardValue.Value);
		}

		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
		{
			writer.WritePropertyName("auto_generate_synonyms_phrase_query");
			writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (DefaultOperatorValue is not null)
		{
			writer.WritePropertyName("default_operator");
			JsonSerializer.Serialize(writer, DefaultOperatorValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (FuzzyMaxExpansionsValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_max_expansions");
			writer.WriteNumberValue(FuzzyMaxExpansionsValue.Value);
		}

		if (FuzzyPrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_prefix_length");
			writer.WriteNumberValue(FuzzyPrefixLengthValue.Value);
		}

		if (FuzzyTranspositionsValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_transpositions");
			writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
		}

		if (LenientValue.HasValue)
		{
			writer.WritePropertyName("lenient");
			writer.WriteBooleanValue(LenientValue.Value);
		}

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(QuoteFieldSuffixValue))
		{
			writer.WritePropertyName("quote_field_suffix");
			writer.WriteStringValue(QuoteFieldSuffixValue);
		}

		writer.WriteEndObject();
	}
}