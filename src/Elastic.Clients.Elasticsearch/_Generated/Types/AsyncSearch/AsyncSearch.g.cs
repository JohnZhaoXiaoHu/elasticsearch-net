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

namespace Elastic.Clients.Elasticsearch.AsyncSearch;

public sealed partial class AsyncSearch<TDocument>
{
	[JsonInclude, JsonPropertyName("_clusters")]
	public Elastic.Clients.Elasticsearch.ClusterStatistics? Clusters { get; init; }
	[JsonInclude, JsonPropertyName("_scroll_id")]
	public Elastic.Clients.Elasticsearch.ScrollId? ScrollId { get; init; }

	/// <summary>
	/// <para>Indicates how many shards have run the query.<br/>Note that in order for shard results to be included in the search response, they need to be reduced first.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_shards")]
	public Elastic.Clients.Elasticsearch.ShardStatistics Shards { get; init; }

	/// <summary>
	/// <para>Partial aggregations results, coming from the shards that have already completed the execution of the query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aggregations")]
	public Elastic.Clients.Elasticsearch.Aggregations.AggregateDictionary? Aggregations { get; init; }
	[JsonInclude, JsonPropertyName("fields")]
	public IReadOnlyDictionary<string, object>? Fields { get; init; }
	[JsonInclude, JsonPropertyName("hits")]
	public Elastic.Clients.Elasticsearch.Core.Search.HitsMetadata<TDocument> HitsMetadata { get; init; }
	[JsonInclude, JsonPropertyName("max_score")]
	public double? MaxScore { get; init; }

	/// <summary>
	/// <para>Indicates how many reductions of the results have been performed.<br/>If this number increases compared to the last retrieved results for a get asynch search request, you can expect additional results included in the search response.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("num_reduce_phases")]
	public long? NumReducePhases { get; init; }
	[JsonInclude, JsonPropertyName("pit_id")]
	public string? PitId { get; init; }
	[JsonInclude, JsonPropertyName("profile")]
	public Elastic.Clients.Elasticsearch.Core.Search.Profile? Profile { get; init; }
	[JsonInclude, JsonPropertyName("terminated_early")]
	public bool? TerminatedEarly { get; init; }
	[JsonInclude, JsonPropertyName("timed_out")]
	public bool TimedOut { get; init; }
	[JsonInclude, JsonPropertyName("took")]
	public long Took { get; init; }
}