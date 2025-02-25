// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using body_complex.Models;

namespace body_complex
{
    /// <summary> The Polymorphism service client. </summary>
    public partial class PolymorphismClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PolymorphismRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PolymorphismClient for mocking. </summary>
        protected PolymorphismClient()
        {
        }

        /// <summary> Initializes a new instance of PolymorphismClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal PolymorphismClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new PolymorphismRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Fish>> GetValidAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetValid");
            scope.Start();
            try
            {
                return await RestClient.GetValidAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Fish> GetValid(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetValid");
            scope.Start();
            try
            {
                return RestClient.GetValid(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///         &apos;fishtype&apos;:&apos;Salmon&apos;,
        ///         &apos;location&apos;:&apos;alaska&apos;,
        ///         &apos;iswild&apos;:true,
        ///         &apos;species&apos;:&apos;king&apos;,
        ///         &apos;length&apos;:1.0,
        ///         &apos;siblings&apos;:[
        ///           {
        ///             &apos;fishtype&apos;:&apos;Shark&apos;,
        ///             &apos;age&apos;:6,
        ///             &apos;birthday&apos;: &apos;2012-01-05T01:00:00Z&apos;,
        ///             &apos;length&apos;:20.0,
        ///             &apos;species&apos;:&apos;predator&apos;,
        ///           },
        ///           {
        ///             &apos;fishtype&apos;:&apos;Sawshark&apos;,
        ///             &apos;age&apos;:105,
        ///             &apos;birthday&apos;: &apos;1900-01-05T01:00:00Z&apos;,
        ///             &apos;length&apos;:10.0,
        ///             &apos;picture&apos;: new Buffer([255, 255, 255, 255, 254]).toString(&apos;base64&apos;),
        ///             &apos;species&apos;:&apos;dangerous&apos;,
        ///           },
        ///           {
        ///             &apos;fishtype&apos;: &apos;goblin&apos;,
        ///             &apos;age&apos;: 1,
        ///             &apos;birthday&apos;: &apos;2015-08-08T00:00:00Z&apos;,
        ///             &apos;length&apos;: 30.0,
        ///             &apos;species&apos;: &apos;scary&apos;,
        ///             &apos;jawsize&apos;: 5
        ///           }
        ///         ]
        ///       };
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutValidAsync(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutValid");
            scope.Start();
            try
            {
                return await RestClient.PutValidAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///         &apos;fishtype&apos;:&apos;Salmon&apos;,
        ///         &apos;location&apos;:&apos;alaska&apos;,
        ///         &apos;iswild&apos;:true,
        ///         &apos;species&apos;:&apos;king&apos;,
        ///         &apos;length&apos;:1.0,
        ///         &apos;siblings&apos;:[
        ///           {
        ///             &apos;fishtype&apos;:&apos;Shark&apos;,
        ///             &apos;age&apos;:6,
        ///             &apos;birthday&apos;: &apos;2012-01-05T01:00:00Z&apos;,
        ///             &apos;length&apos;:20.0,
        ///             &apos;species&apos;:&apos;predator&apos;,
        ///           },
        ///           {
        ///             &apos;fishtype&apos;:&apos;Sawshark&apos;,
        ///             &apos;age&apos;:105,
        ///             &apos;birthday&apos;: &apos;1900-01-05T01:00:00Z&apos;,
        ///             &apos;length&apos;:10.0,
        ///             &apos;picture&apos;: new Buffer([255, 255, 255, 255, 254]).toString(&apos;base64&apos;),
        ///             &apos;species&apos;:&apos;dangerous&apos;,
        ///           },
        ///           {
        ///             &apos;fishtype&apos;: &apos;goblin&apos;,
        ///             &apos;age&apos;: 1,
        ///             &apos;birthday&apos;: &apos;2015-08-08T00:00:00Z&apos;,
        ///             &apos;length&apos;: 30.0,
        ///             &apos;species&apos;: &apos;scary&apos;,
        ///             &apos;jawsize&apos;: 5
        ///           }
        ///         ]
        ///       };
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutValid(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutValid");
            scope.Start();
            try
            {
                return RestClient.PutValid(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DotFish>> GetDotSyntaxAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetDotSyntax");
            scope.Start();
            try
            {
                return await RestClient.GetDotSyntaxAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DotFish> GetDotSyntax(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetDotSyntax");
            scope.Start();
            try
            {
                return RestClient.GetDotSyntax(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DotFishMarket>> GetComposedWithDiscriminatorAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithDiscriminator");
            scope.Start();
            try
            {
                return await RestClient.GetComposedWithDiscriminatorAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DotFishMarket> GetComposedWithDiscriminator(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithDiscriminator");
            scope.Start();
            try
            {
                return RestClient.GetComposedWithDiscriminator(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DotFishMarket>> GetComposedWithoutDiscriminatorAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithoutDiscriminator");
            scope.Start();
            try
            {
                return await RestClient.GetComposedWithoutDiscriminatorAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DotFishMarket> GetComposedWithoutDiscriminator(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithoutDiscriminator");
            scope.Start();
            try
            {
                return RestClient.GetComposedWithoutDiscriminator(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Salmon>> GetComplicatedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComplicated");
            scope.Start();
            try
            {
                return await RestClient.GetComplicatedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Salmon> GetComplicated(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComplicated");
            scope.Start();
            try
            {
                return RestClient.GetComplicated(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="complexBody"> The Salmon to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutComplicatedAsync(Salmon complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutComplicated");
            scope.Start();
            try
            {
                return await RestClient.PutComplicatedAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="complexBody"> The Salmon to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutComplicated(Salmon complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutComplicated");
            scope.Start();
            try
            {
                return RestClient.PutComplicated(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="complexBody"> The Salmon to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Salmon>> PutMissingDiscriminatorAsync(Salmon complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutMissingDiscriminator");
            scope.Start();
            try
            {
                return await RestClient.PutMissingDiscriminatorAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="complexBody"> The Salmon to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Salmon> PutMissingDiscriminator(Salmon complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutMissingDiscriminator");
            scope.Start();
            try
            {
                return RestClient.PutMissingDiscriminator(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, attempting to omit required &apos;birthday&apos; field - the request should not be allowed from the client. </summary>
        /// <param name="complexBody">
        /// Please attempt put a sawshark that looks like this, the client should not allow this data to be sent:
        /// {
        ///     &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///     &quot;species&quot;: &quot;snaggle toothed&quot;,
        ///     &quot;length&quot;: 18.5,
        ///     &quot;age&quot;: 2,
        ///     &quot;birthday&quot;: &quot;2013-06-01T01:00:00Z&quot;,
        ///     &quot;location&quot;: &quot;alaska&quot;,
        ///     &quot;picture&quot;: base64(FF FF FF FF FE),
        ///     &quot;siblings&quot;: [
        ///         {
        ///             &quot;fishtype&quot;: &quot;shark&quot;,
        ///             &quot;species&quot;: &quot;predator&quot;,
        ///             &quot;birthday&quot;: &quot;2012-01-05T01:00:00Z&quot;,
        ///             &quot;length&quot;: 20,
        ///             &quot;age&quot;: 6
        ///         },
        ///         {
        ///             &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///             &quot;species&quot;: &quot;dangerous&quot;,
        ///             &quot;picture&quot;: base64(FF FF FF FF FE),
        ///             &quot;length&quot;: 10,
        ///             &quot;age&quot;: 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutValidMissingRequiredAsync(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutValidMissingRequired");
            scope.Start();
            try
            {
                return await RestClient.PutValidMissingRequiredAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, attempting to omit required &apos;birthday&apos; field - the request should not be allowed from the client. </summary>
        /// <param name="complexBody">
        /// Please attempt put a sawshark that looks like this, the client should not allow this data to be sent:
        /// {
        ///     &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///     &quot;species&quot;: &quot;snaggle toothed&quot;,
        ///     &quot;length&quot;: 18.5,
        ///     &quot;age&quot;: 2,
        ///     &quot;birthday&quot;: &quot;2013-06-01T01:00:00Z&quot;,
        ///     &quot;location&quot;: &quot;alaska&quot;,
        ///     &quot;picture&quot;: base64(FF FF FF FF FE),
        ///     &quot;siblings&quot;: [
        ///         {
        ///             &quot;fishtype&quot;: &quot;shark&quot;,
        ///             &quot;species&quot;: &quot;predator&quot;,
        ///             &quot;birthday&quot;: &quot;2012-01-05T01:00:00Z&quot;,
        ///             &quot;length&quot;: 20,
        ///             &quot;age&quot;: 6
        ///         },
        ///         {
        ///             &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///             &quot;species&quot;: &quot;dangerous&quot;,
        ///             &quot;picture&quot;: base64(FF FF FF FF FE),
        ///             &quot;length&quot;: 10,
        ///             &quot;age&quot;: 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutValidMissingRequired(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutValidMissingRequired");
            scope.Start();
            try
            {
                return RestClient.PutValidMissingRequired(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
