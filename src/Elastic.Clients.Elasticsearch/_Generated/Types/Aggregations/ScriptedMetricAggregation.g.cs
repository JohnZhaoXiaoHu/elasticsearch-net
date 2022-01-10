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
	internal sealed class ScriptedMetricAggregationConverter : JsonConverter<ScriptedMetricAggregation>
	{
		public override ScriptedMetricAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "scripted_metric")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new ScriptedMetricAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("combine_script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.CombineScript = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("init_script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.InitScript = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("map_script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.MapScript = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("params"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>?>(ref reader, options);
						if (value is not null)
						{
							agg.Params = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("reduce_script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.ReduceScript = value;
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

		public override void Write(Utf8JsonWriter writer, ScriptedMetricAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("scripted_metric");
			writer.WriteStartObject();
			if (value.CombineScript is not null)
			{
				writer.WritePropertyName("combine_script");
				JsonSerializer.Serialize(writer, value.CombineScript, options);
			}

			if (value.InitScript is not null)
			{
				writer.WritePropertyName("init_script");
				JsonSerializer.Serialize(writer, value.InitScript, options);
			}

			if (value.MapScript is not null)
			{
				writer.WritePropertyName("map_script");
				JsonSerializer.Serialize(writer, value.MapScript, options);
			}

			if (value.Params is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, value.Params, options);
			}

			if (value.ReduceScript is not null)
			{
				writer.WritePropertyName("reduce_script");
				JsonSerializer.Serialize(writer, value.ReduceScript, options);
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

	[JsonConverter(typeof(ScriptedMetricAggregationConverter))]
	public partial class ScriptedMetricAggregation : Aggregations.MetricAggregationBase
	{
		public ScriptedMetricAggregation(string name, Field field) : base(name) => Field = field;
		public ScriptedMetricAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("combine_script")]
		public Elastic.Clients.Elasticsearch.ScriptBase? CombineScript { get; set; }

		[JsonInclude]
		[JsonPropertyName("init_script")]
		public Elastic.Clients.Elasticsearch.ScriptBase? InitScript { get; set; }

		[JsonInclude]
		[JsonPropertyName("map_script")]
		public Elastic.Clients.Elasticsearch.ScriptBase? MapScript { get; set; }

		[JsonInclude]
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonInclude]
		[JsonPropertyName("reduce_script")]
		public Elastic.Clients.Elasticsearch.ScriptBase? ReduceScript { get; set; }
	}

	public sealed partial class ScriptedMetricAggregationDescriptor<TDocument> : DescriptorBase<ScriptedMetricAggregationDescriptor<TDocument>>
	{
		public ScriptedMetricAggregationDescriptor()
		{
		}

		internal ScriptedMetricAggregationDescriptor(Action<ScriptedMetricAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.ScriptBase? CombineScriptValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptBase? InitScriptValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptBase? MapScriptValue { get; private set; }

		internal Dictionary<string, object>? ParamsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptBase? ReduceScriptValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptBase? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptDescriptor CombineScriptDescriptor { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptDescriptor InitScriptDescriptor { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptDescriptor MapScriptDescriptor { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptDescriptor ReduceScriptDescriptor { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> CombineScriptDescriptorAction { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> InitScriptDescriptorAction { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> MapScriptDescriptorAction { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ReduceScriptDescriptorAction { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; private set; }

		public ScriptedMetricAggregationDescriptor<TDocument> CombineScript(Elastic.Clients.Elasticsearch.ScriptBase? combineScript)
		{
			CombineScriptDescriptor = null;
			CombineScriptDescriptorAction = null;
			return Assign(combineScript, (a, v) => a.CombineScriptValue = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> CombineScript(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
		{
			CombineScriptValue = null;
			CombineScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.CombineScriptDescriptor = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> CombineScript(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
		{
			CombineScriptValue = null;
			CombineScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.CombineScriptDescriptorAction = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> InitScript(Elastic.Clients.Elasticsearch.ScriptBase? initScript)
		{
			InitScriptDescriptor = null;
			InitScriptDescriptorAction = null;
			return Assign(initScript, (a, v) => a.InitScriptValue = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> InitScript(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
		{
			InitScriptValue = null;
			InitScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.InitScriptDescriptor = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> InitScript(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
		{
			InitScriptValue = null;
			InitScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.InitScriptDescriptorAction = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> MapScript(Elastic.Clients.Elasticsearch.ScriptBase? mapScript)
		{
			MapScriptDescriptor = null;
			MapScriptDescriptorAction = null;
			return Assign(mapScript, (a, v) => a.MapScriptValue = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> MapScript(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
		{
			MapScriptValue = null;
			MapScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.MapScriptDescriptor = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> MapScript(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
		{
			MapScriptValue = null;
			MapScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.MapScriptDescriptorAction = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.ParamsValue = v?.Invoke(new FluentDictionary<string, object>()));
		public ScriptedMetricAggregationDescriptor<TDocument> ReduceScript(Elastic.Clients.Elasticsearch.ScriptBase? reduceScript)
		{
			ReduceScriptDescriptor = null;
			ReduceScriptDescriptorAction = null;
			return Assign(reduceScript, (a, v) => a.ReduceScriptValue = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> ReduceScript(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
		{
			ReduceScriptValue = null;
			ReduceScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ReduceScriptDescriptor = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> ReduceScript(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
		{
			ReduceScriptValue = null;
			ReduceScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.ReduceScriptDescriptorAction = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public ScriptedMetricAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public ScriptedMetricAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			return Assign(script, (a, v) => a.ScriptValue = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ScriptDescriptor = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.ScriptDescriptorAction = v);
		}

		public ScriptedMetricAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("scripted_metric");
			writer.WriteStartObject();
			if (CombineScriptDescriptor is not null)
			{
				writer.WritePropertyName("combine_script");
				JsonSerializer.Serialize(writer, CombineScriptDescriptor, options);
			}
			else if (CombineScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("combine_script");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(CombineScriptDescriptorAction), options);
			}
			else if (CombineScriptValue is not null)
			{
				writer.WritePropertyName("combine_script");
				JsonSerializer.Serialize(writer, CombineScriptValue, options);
			}

			if (InitScriptDescriptor is not null)
			{
				writer.WritePropertyName("init_script");
				JsonSerializer.Serialize(writer, InitScriptDescriptor, options);
			}
			else if (InitScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("init_script");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(InitScriptDescriptorAction), options);
			}
			else if (InitScriptValue is not null)
			{
				writer.WritePropertyName("init_script");
				JsonSerializer.Serialize(writer, InitScriptValue, options);
			}

			if (MapScriptDescriptor is not null)
			{
				writer.WritePropertyName("map_script");
				JsonSerializer.Serialize(writer, MapScriptDescriptor, options);
			}
			else if (MapScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("map_script");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(MapScriptDescriptorAction), options);
			}
			else if (MapScriptValue is not null)
			{
				writer.WritePropertyName("map_script");
				JsonSerializer.Serialize(writer, MapScriptValue, options);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (ReduceScriptDescriptor is not null)
			{
				writer.WritePropertyName("reduce_script");
				JsonSerializer.Serialize(writer, ReduceScriptDescriptor, options);
			}
			else if (ReduceScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("reduce_script");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ReduceScriptDescriptorAction), options);
			}
			else if (ReduceScriptValue is not null)
			{
				writer.WritePropertyName("reduce_script");
				JsonSerializer.Serialize(writer, ReduceScriptValue, options);
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