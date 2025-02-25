// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtMockTest;
using MgmtMockTest.Models;

namespace MgmtMockTest.Tests.Mock
{
    /// <summary> Test for MgmtMockTestPrivateEndpointConnectionResource. </summary>
    public partial class MgmtMockTestPrivateEndpointConnectionResourceMockTests : MockTestBase
    {
        public MgmtMockTestPrivateEndpointConnectionResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: KeyVaultDeletePrivateEndpointConnection

            var mgmtMockTestPrivateEndpointConnectionResourceId = MgmtMockTest.MgmtMockTestPrivateEndpointConnectionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault", "sample-pec");
            var mgmtMockTestPrivateEndpointConnectionResource = GetArmClient().GetMgmtMockTestPrivateEndpointConnectionResource(mgmtMockTestPrivateEndpointConnectionResourceId);
            await mgmtMockTestPrivateEndpointConnectionResource.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: KeyVaultGetPrivateEndpointConnection

            var mgmtMockTestPrivateEndpointConnectionResourceId = MgmtMockTest.MgmtMockTestPrivateEndpointConnectionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault", "sample-pec");
            var mgmtMockTestPrivateEndpointConnectionResource = GetArmClient().GetMgmtMockTestPrivateEndpointConnectionResource(mgmtMockTestPrivateEndpointConnectionResourceId);
            await mgmtMockTestPrivateEndpointConnectionResource.GetAsync();
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: KeyVaultPutPrivateEndpointConnection

            var mgmtMockTestPrivateEndpointConnectionResourceId = MgmtMockTest.MgmtMockTestPrivateEndpointConnectionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault", "sample-pec");
            var mgmtMockTestPrivateEndpointConnectionResource = GetArmClient().GetMgmtMockTestPrivateEndpointConnectionResource(mgmtMockTestPrivateEndpointConnectionResourceId);
            await mgmtMockTestPrivateEndpointConnectionResource.UpdateAsync(WaitUntil.Completed, new MgmtMockTestPrivateEndpointConnectionData()
            {
                Etag = "",
                ConnectionState = new MgmtMockTestPrivateLinkServiceConnectionState()
                {
                    Status = MgmtMockTestPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "My name is Joe and I'm approving this.",
                },
            });
        }
    }
}
