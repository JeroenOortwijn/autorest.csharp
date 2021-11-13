// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace SingleTopLevelClientWithoutOperations_LowLevel
{
    /// <summary> The TopLevelClientWithoutOperation service client. </summary>
    public partial class TopLevelClientWithoutOperationClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of TopLevelClientWithoutOperationClient for mocking. </summary>
        protected TopLevelClientWithoutOperationClient()
        {
        }

        /// <summary> Initializes a new instance of TopLevelClientWithoutOperationClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public TopLevelClientWithoutOperationClient(AzureKeyCredential credential, Uri endpoint = null, TopLevelClientWithoutOperationClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");
            options ??= new TopLevelClientWithoutOperationClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        private Client3 _cachedClient3;
        private Client4 _cachedClient4;
        private Client5 _cachedClient5;

        /// <summary> Initializes a new instance of Client3. </summary>
        public virtual Client3 GetClient3Client()
        {
            return Volatile.Read(ref _cachedClient3) ?? Interlocked.CompareExchange(ref _cachedClient3, new Client3(_clientDiagnostics, _pipeline, _keyCredential, _endpoint), null) ?? _cachedClient3;
        }

        /// <summary> Initializes a new instance of Client4. </summary>
        public virtual Client4 GetClient4Client()
        {
            return Volatile.Read(ref _cachedClient4) ?? Interlocked.CompareExchange(ref _cachedClient4, new Client4(_clientDiagnostics, _pipeline, _keyCredential, _endpoint), null) ?? _cachedClient4;
        }

        /// <summary> Initializes a new instance of Client5. </summary>
        public virtual Client5 GetClient5Client()
        {
            return Volatile.Read(ref _cachedClient5) ?? Interlocked.CompareExchange(ref _cachedClient5, new Client5(_clientDiagnostics, _pipeline, _keyCredential, _endpoint), null) ?? _cachedClient5;
        }
    }
}
