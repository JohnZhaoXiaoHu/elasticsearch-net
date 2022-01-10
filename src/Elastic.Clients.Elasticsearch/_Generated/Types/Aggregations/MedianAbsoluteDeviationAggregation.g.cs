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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class MedianAbsoluteDeviationAggregationConverter : JsonConverter<MedianAbsoluteDeviationAggregation>
	{
		public override MedianAbsoluteDeviationAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "median_absolute_deviation")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new MedianAbsoluteDeviationAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("compression"))
					{
						var value = JsonSerializer.Deserialize<double?>(ref reader, options);
						if (value is not null)
						{
							agg.Compression = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, MedianAbsoluteDeviationAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("median_absolute_deviation");
			writer.WriteStartObject();
			if (value.Compression.HasValue)
			{
				writer.WritePropertyName("compression");
				writer.WriteNumberValue(value.Compression.Value);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(MedianAbsoluteDeviationAggregationConverter))]
	public partial class MedianAbsoluteDeviationAggregation : Aggregations.FormatMetricAggregationBase
	{
		public MedianAbsoluteDeviationAggregation(string name, Field field) : base(name) => Field = field;
		public MedianAbsoluteDeviationAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("compression")]
		public double? Compression { get; set; }
	}

	public sealed partial class MedianAbsoluteDeviationAggregationDescriptor<TDocument> : DescriptorBase<MedianAbsoluteDeviationAggregationDescriptor<TDocument>>
	{
		public MedianAbsoluteDeviationAggregationDescriptor()
		{
		}

		internal MedianAbsoluteDeviationAggregationDescriptor(Action<MedianAbsoluteDeviationAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal double? CompressionValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptBase? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; private set; }

		public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Compression(double? compression) => Assign(compression, (a, v) => a.CompressionValue = v);
		public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			return Assign(script, (a, v) => a.ScriptValue = v);
		}

		public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ScriptDescriptor = v);
		}

		public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.ScriptDescriptorAction = v);
		}

		public MedianAbsoluteDeviationAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("median_absolute_deviation");
			writer.WriteStartObject();
			if (CompressionValue.HasValue)
			{
				writer.WritePropertyName("compression");
				writer.WriteNumberValue(CompressionValue.Value);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}