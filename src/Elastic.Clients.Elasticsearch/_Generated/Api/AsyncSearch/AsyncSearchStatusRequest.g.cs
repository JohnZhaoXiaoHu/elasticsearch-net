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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.AsyncSearch;

public sealed class AsyncSearchStatusRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Retreives the status of a previously submitted async search request given its identifier, without retrieving search results.<br/>If the Elasticsearch security features are enabled, use of this API is restricted to the `monitoring_user` role.</para>
/// </summary>
public sealed partial class AsyncSearchStatusRequest : PlainRequest<AsyncSearchStatusRequestParameters>
{
	public AsyncSearchStatusRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.AsyncSearchStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;
}

/// <summary>
/// <para>Retreives the status of a previously submitted async search request given its identifier, without retrieving search results.<br/>If the Elasticsearch security features are enabled, use of this API is restricted to the `monitoring_user` role.</para>
/// </summary>
public sealed partial class AsyncSearchStatusRequestDescriptor<TDocument> : RequestDescriptor<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusRequestParameters>
{
	internal AsyncSearchStatusRequestDescriptor(Action<AsyncSearchStatusRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public AsyncSearchStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal AsyncSearchStatusRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.AsyncSearchStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	public AsyncSearchStatusRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Retreives the status of a previously submitted async search request given its identifier, without retrieving search results.<br/>If the Elasticsearch security features are enabled, use of this API is restricted to the `monitoring_user` role.</para>
/// </summary>
public sealed partial class AsyncSearchStatusRequestDescriptor : RequestDescriptor<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusRequestParameters>
{
	internal AsyncSearchStatusRequestDescriptor(Action<AsyncSearchStatusRequestDescriptor> configure) => configure.Invoke(this);

	public AsyncSearchStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal AsyncSearchStatusRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.AsyncSearchStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	public AsyncSearchStatusRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}