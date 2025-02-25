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

namespace Elastic.Clients.Elasticsearch.Cluster;

public sealed partial class OperatingSystemMemoryInfo
{
	[JsonInclude, JsonPropertyName("adjusted_total_in_bytes")]
	public long? AdjustedTotalInBytes { get; init; }
	[JsonInclude, JsonPropertyName("free_in_bytes")]
	public long FreeInBytes { get; init; }
	[JsonInclude, JsonPropertyName("free_percent")]
	public int FreePercent { get; init; }
	[JsonInclude, JsonPropertyName("total_in_bytes")]
	public long TotalInBytes { get; init; }
	[JsonInclude, JsonPropertyName("used_in_bytes")]
	public long UsedInBytes { get; init; }
	[JsonInclude, JsonPropertyName("used_percent")]
	public int UsedPercent { get; init; }
}