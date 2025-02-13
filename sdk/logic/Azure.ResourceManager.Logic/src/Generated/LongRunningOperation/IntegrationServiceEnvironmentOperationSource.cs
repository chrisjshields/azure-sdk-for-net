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

namespace Azure.ResourceManager.Logic
{
    internal class IntegrationServiceEnvironmentOperationSource : IOperationSource<IntegrationServiceEnvironmentResource>
    {
        private readonly ArmClient _client;

        internal IntegrationServiceEnvironmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        IntegrationServiceEnvironmentResource IOperationSource<IntegrationServiceEnvironmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IntegrationServiceEnvironmentData.DeserializeIntegrationServiceEnvironmentData(document.RootElement);
            return new IntegrationServiceEnvironmentResource(_client, data);
        }

        async ValueTask<IntegrationServiceEnvironmentResource> IOperationSource<IntegrationServiceEnvironmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IntegrationServiceEnvironmentData.DeserializeIntegrationServiceEnvironmentData(document.RootElement);
            return new IntegrationServiceEnvironmentResource(_client, data);
        }
    }
}
