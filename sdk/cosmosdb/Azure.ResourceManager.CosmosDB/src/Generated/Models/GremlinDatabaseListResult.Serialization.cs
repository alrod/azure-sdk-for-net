// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class GremlinDatabaseListResult
    {
        internal static GremlinDatabaseListResult DeserializeGremlinDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<GremlinDatabaseGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<GremlinDatabaseGetResults> array = new List<GremlinDatabaseGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GremlinDatabaseGetResults.DeserializeGremlinDatabaseGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new GremlinDatabaseListResult(Optional.ToList(value));
        }
    }
}
