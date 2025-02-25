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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class IndexTemplateSummary
{
	[JsonInclude, JsonPropertyName("aliases")]
	[ReadOnlyIndexNameDictionaryConverter(typeof(Elastic.Clients.Elasticsearch.IndexManagement.Alias))]
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; init; }
	[JsonInclude, JsonPropertyName("lifecycle")]
	public Elastic.Clients.Elasticsearch.IndexManagement.DataLifecycleWithRollover? Lifecycle { get; init; }
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; init; }
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? Settings { get; init; }
}