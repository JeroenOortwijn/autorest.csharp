// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using CognitiveSearch.Models;

namespace CognitiveSearch
{
    internal partial class SynonymMapsRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of SynonymMapsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint URL of the search service. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public SynonymMapsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-05-06-Preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string synonymMapName, SynonymMap synonymMap, RequestOptions requestOptions, AccessCondition accessCondition)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/synonymmaps('", false);
            uri.AppendPath(synonymMapName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (requestOptions?.XMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", requestOptions.XMsClientRequestId.Value);
            }
            if (accessCondition?.IfMatch != null)
            {
                request.Headers.Add("If-Match", accessCondition.IfMatch);
            }
            if (accessCondition?.IfNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", accessCondition.IfNoneMatch);
            }
            request.Headers.Add("Prefer", "return=representation");
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(synonymMap);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new synonym map or updates a synonym map if it already exists. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SynonymMap>> CreateOrUpdateAsync(string synonymMapName, SynonymMap synonymMap, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }
            if (synonymMap == null)
            {
                throw new ArgumentNullException(nameof(synonymMap));
            }

            using var message = CreateCreateOrUpdateRequest(synonymMapName, synonymMap, requestOptions, accessCondition);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SynonymMap value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new synonym map or updates a synonym map if it already exists. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SynonymMap> CreateOrUpdate(string synonymMapName, SynonymMap synonymMap, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }
            if (synonymMap == null)
            {
                throw new ArgumentNullException(nameof(synonymMap));
            }

            using var message = CreateCreateOrUpdateRequest(synonymMapName, synonymMap, requestOptions, accessCondition);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SynonymMap value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string synonymMapName, RequestOptions requestOptions, AccessCondition accessCondition)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/synonymmaps('", false);
            uri.AppendPath(synonymMapName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (requestOptions?.XMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", requestOptions.XMsClientRequestId.Value);
            }
            if (accessCondition?.IfMatch != null)
            {
                request.Headers.Add("If-Match", accessCondition.IfMatch);
            }
            if (accessCondition?.IfNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", accessCondition.IfNoneMatch);
            }
            return message;
        }

        /// <summary> Deletes a synonym map. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to delete. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(string synonymMapName, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }

            using var message = CreateDeleteRequest(synonymMapName, requestOptions, accessCondition);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a synonym map. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to delete. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string synonymMapName, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }

            using var message = CreateDeleteRequest(synonymMapName, requestOptions, accessCondition);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string synonymMapName, RequestOptions requestOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/synonymmaps('", false);
            uri.AppendPath(synonymMapName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (requestOptions?.XMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", requestOptions.XMsClientRequestId.Value);
            }
            return message;
        }

        /// <summary> Retrieves a synonym map definition. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to retrieve. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SynonymMap>> GetAsync(string synonymMapName, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }

            using var message = CreateGetRequest(synonymMapName, requestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynonymMap value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves a synonym map definition. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to retrieve. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SynonymMap> Get(string synonymMapName, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }

            using var message = CreateGetRequest(synonymMapName, requestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynonymMap value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string select, RequestOptions requestOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/synonymmaps", false);
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (requestOptions?.XMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", requestOptions.XMsClientRequestId.Value);
            }
            return message;
        }

        /// <summary> Lists all synonym maps available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the synonym maps to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListSynonymMapsResult>> ListAsync(string select = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select, requestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSynonymMapsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ListSynonymMapsResult.DeserializeListSynonymMapsResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all synonym maps available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the synonym maps to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListSynonymMapsResult> List(string select = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select, requestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSynonymMapsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ListSynonymMapsResult.DeserializeListSynonymMapsResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(SynonymMap synonymMap, RequestOptions requestOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/synonymmaps", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (requestOptions?.XMsClientRequestId != null)
            {
                request.Headers.Add("x-ms-client-request-id", requestOptions.XMsClientRequestId.Value);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(synonymMap);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new synonym map. </summary>
        /// <param name="synonymMap"> The definition of the synonym map to create. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SynonymMap>> CreateAsync(SynonymMap synonymMap, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            if (synonymMap == null)
            {
                throw new ArgumentNullException(nameof(synonymMap));
            }

            using var message = CreateCreateRequest(synonymMap, requestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        SynonymMap value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new synonym map. </summary>
        /// <param name="synonymMap"> The definition of the synonym map to create. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SynonymMap> Create(SynonymMap synonymMap, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            if (synonymMap == null)
            {
                throw new ArgumentNullException(nameof(synonymMap));
            }

            using var message = CreateCreateRequest(synonymMap, requestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        SynonymMap value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
