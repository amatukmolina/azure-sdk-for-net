// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetworkCloud
{
    internal class StorageApplianceOperationSource : IOperationSource<StorageApplianceResource>
    {
        private readonly ArmClient _client;

        internal StorageApplianceOperationSource(ArmClient client)
        {
            _client = client;
        }

        StorageApplianceResource IOperationSource<StorageApplianceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StorageApplianceData.DeserializeStorageApplianceData(document.RootElement);
            return new StorageApplianceResource(_client, data);
        }

        async ValueTask<StorageApplianceResource> IOperationSource<StorageApplianceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StorageApplianceData.DeserializeStorageApplianceData(document.RootElement);
            return new StorageApplianceResource(_client, data);
        }
    }
}
