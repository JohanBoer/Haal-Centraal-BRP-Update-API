/*
 * BRP Update API
 *
 * Met deze API kun je opvragen welke door jou gevolgde personen zijn gewijzigd in de BRP. Je kunt je abonneren op een persoon die je wilt volgen, en je kunt opvragen welke personen door jou worden gevolgd. Je kunt deze API gebruiken in combinatie met de BRP bevragen API, bijvoorbeeld om lokale kopiegegevens actueel te houden.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRaadplegenGewijzigdePersonenApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Raadpleeg personen met gewijzigde gegevens
        /// </summary>
        /// <remarks>
        /// Vraag een lijst op met burgerservicenummers van personen met gewijzigde gegevens. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vanaf">Alleen personen waarbij gegevens zijn gewijzigd op of na deze datum worden geleverd. (optional)</param>
        /// <returns>GewijzigdePersonenHalCollectie</returns>
        GewijzigdePersonenHalCollectie GetGewijzigdePersonen(DateTime? vanaf = default(DateTime?));

        /// <summary>
        /// Raadpleeg personen met gewijzigde gegevens
        /// </summary>
        /// <remarks>
        /// Vraag een lijst op met burgerservicenummers van personen met gewijzigde gegevens. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vanaf">Alleen personen waarbij gegevens zijn gewijzigd op of na deze datum worden geleverd. (optional)</param>
        /// <returns>ApiResponse of GewijzigdePersonenHalCollectie</returns>
        ApiResponse<GewijzigdePersonenHalCollectie> GetGewijzigdePersonenWithHttpInfo(DateTime? vanaf = default(DateTime?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRaadplegenGewijzigdePersonenApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Raadpleeg personen met gewijzigde gegevens
        /// </summary>
        /// <remarks>
        /// Vraag een lijst op met burgerservicenummers van personen met gewijzigde gegevens. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vanaf">Alleen personen waarbij gegevens zijn gewijzigd op of na deze datum worden geleverd. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GewijzigdePersonenHalCollectie</returns>
        System.Threading.Tasks.Task<GewijzigdePersonenHalCollectie> GetGewijzigdePersonenAsync(DateTime? vanaf = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Raadpleeg personen met gewijzigde gegevens
        /// </summary>
        /// <remarks>
        /// Vraag een lijst op met burgerservicenummers van personen met gewijzigde gegevens. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vanaf">Alleen personen waarbij gegevens zijn gewijzigd op of na deze datum worden geleverd. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GewijzigdePersonenHalCollectie)</returns>
        System.Threading.Tasks.Task<ApiResponse<GewijzigdePersonenHalCollectie>> GetGewijzigdePersonenWithHttpInfoAsync(DateTime? vanaf = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRaadplegenGewijzigdePersonenApi : IRaadplegenGewijzigdePersonenApiSync, IRaadplegenGewijzigdePersonenApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RaadplegenGewijzigdePersonenApi : IRaadplegenGewijzigdePersonenApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RaadplegenGewijzigdePersonenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RaadplegenGewijzigdePersonenApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RaadplegenGewijzigdePersonenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RaadplegenGewijzigdePersonenApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RaadplegenGewijzigdePersonenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RaadplegenGewijzigdePersonenApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RaadplegenGewijzigdePersonenApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RaadplegenGewijzigdePersonenApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Raadpleeg personen met gewijzigde gegevens Vraag een lijst op met burgerservicenummers van personen met gewijzigde gegevens. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vanaf">Alleen personen waarbij gegevens zijn gewijzigd op of na deze datum worden geleverd. (optional)</param>
        /// <returns>GewijzigdePersonenHalCollectie</returns>
        public GewijzigdePersonenHalCollectie GetGewijzigdePersonen(DateTime? vanaf = default(DateTime?))
        {
            Org.OpenAPITools.Client.ApiResponse<GewijzigdePersonenHalCollectie> localVarResponse = GetGewijzigdePersonenWithHttpInfo(vanaf);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Raadpleeg personen met gewijzigde gegevens Vraag een lijst op met burgerservicenummers van personen met gewijzigde gegevens. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vanaf">Alleen personen waarbij gegevens zijn gewijzigd op of na deze datum worden geleverd. (optional)</param>
        /// <returns>ApiResponse of GewijzigdePersonenHalCollectie</returns>
        public Org.OpenAPITools.Client.ApiResponse<GewijzigdePersonenHalCollectie> GetGewijzigdePersonenWithHttpInfo(DateTime? vanaf = default(DateTime?))
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/hal+json",
                "application/problem+json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (vanaf != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "vanaf", vanaf));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<GewijzigdePersonenHalCollectie>("/wijzigingen", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGewijzigdePersonen", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Raadpleeg personen met gewijzigde gegevens Vraag een lijst op met burgerservicenummers van personen met gewijzigde gegevens. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vanaf">Alleen personen waarbij gegevens zijn gewijzigd op of na deze datum worden geleverd. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GewijzigdePersonenHalCollectie</returns>
        public async System.Threading.Tasks.Task<GewijzigdePersonenHalCollectie> GetGewijzigdePersonenAsync(DateTime? vanaf = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<GewijzigdePersonenHalCollectie> localVarResponse = await GetGewijzigdePersonenWithHttpInfoAsync(vanaf, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Raadpleeg personen met gewijzigde gegevens Vraag een lijst op met burgerservicenummers van personen met gewijzigde gegevens. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vanaf">Alleen personen waarbij gegevens zijn gewijzigd op of na deze datum worden geleverd. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GewijzigdePersonenHalCollectie)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<GewijzigdePersonenHalCollectie>> GetGewijzigdePersonenWithHttpInfoAsync(DateTime? vanaf = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/hal+json",
                "application/problem+json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (vanaf != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "vanaf", vanaf));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<GewijzigdePersonenHalCollectie>("/wijzigingen", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGewijzigdePersonen", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
