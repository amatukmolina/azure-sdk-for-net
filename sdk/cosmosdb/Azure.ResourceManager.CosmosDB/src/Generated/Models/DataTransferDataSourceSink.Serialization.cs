// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class DataTransferDataSourceSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("component"u8);
            writer.WriteStringValue(Component.ToString());
            writer.WriteEndObject();
        }

        internal static DataTransferDataSourceSink DeserializeDataTransferDataSourceSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("component", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBlobStorage": return AzureBlobDataTransferDataSourceSink.DeserializeAzureBlobDataTransferDataSourceSink(element);
                    case "CosmosDBCassandra": return CosmosCassandraDataTransferDataSourceSink.DeserializeCosmosCassandraDataTransferDataSourceSink(element);
                    case "CosmosDBSql": return CosmosSqlDataTransferDataSourceSink.DeserializeCosmosSqlDataTransferDataSourceSink(element);
                }
            }
            return UnknownDataTransferDataSourceSink.DeserializeUnknownDataTransferDataSourceSink(element);
        }
    }
}
