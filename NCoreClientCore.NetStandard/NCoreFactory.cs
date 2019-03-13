using System;
using Gecko.NCore.Client;
using Gecko.NCore.Client.Functions;
using Gecko.NCore.Client.ObjectModel.V3.En;
using Microsoft.Extensions.Options;

namespace NCoreClientCore.NetStandard
{

    public class NCoreFactory
    {
        readonly NCoreOptions _options;

        //public NCoreFactory(IOptionsMonitor<MyOptions> optionsMonitor)
        public NCoreFactory(IOptions<NCoreOptions> optionsMonitor)
            : this(optionsMonitor.Value)
        {}

        public NCoreFactory(NCoreOptions options)
        {
            _options = options;
        }

        public IEphorteContext Create()
        {
            var identity = new EphorteContextIdentity
            {
                Username = _options.Username,
                Password = _options.Password,
                Role = _options.Role,
                Database = _options.Database,
                ExternalSystemName = _options.ExternalSystemName
            };

            var servicesBaseUrl = new Uri(_options.NCoreBaseAddress, UriKind.Absolute);

            string GetObjectModelServiceAddress()
            {
                const string objectModelServiceUrl = "services/objectmodel/v3/en/ObjectModelService.svc";
                return new Uri(servicesBaseUrl, objectModelServiceUrl).ToString();
            }

            var objectModelAdapter = new ObjectModelAdapterV3En(identity, new ClientSettings
            {
                Address = GetObjectModelServiceAddress(),
            });

            var functionsAdapter = GetFunctionsAdapter(servicesBaseUrl, _options.FunctionServiceVersion, identity);

            string GetDocumentServiceAddress()
            {
                string DocumentServiceUrl = "services/documents/v2/DocumentService.svc";
                ////private const string DocumentServiceUrl = "services/documents/v2/DocumentService.svc/ws";
                ////private const string DocumentServiceUrl = "services/documents/v3/DocumentService.svc";
                return new Uri(servicesBaseUrl, DocumentServiceUrl).ToString();
            }
            var documentsAdapter = new Gecko.NCore.Client.Documents.V2.DocumentsAdapter(identity, new ClientSettings
            {
                Address = GetDocumentServiceAddress(),
            });
            return new EphorteContext(objectModelAdapter, functionsAdapter, documentsAdapter: documentsAdapter, documentsAdapterWithDatabase: null, metadataAdapter: null);
        }

        private static IFunctionsAdapter GetFunctionsAdapter(Uri servicesBaseUrl, string functionServiceVersion, EphorteContextIdentity identity)
        {
            string functionServiceServiceUrl;
            string GetFunctionsServiceAddress()
            {
                return new Uri(servicesBaseUrl, functionServiceServiceUrl).ToString();
            }
            if ("v1".Equals(functionServiceVersion, StringComparison.OrdinalIgnoreCase))
            {
                functionServiceServiceUrl = "services/Functions/V1/FunctionsService.svc/ws";
                return new Gecko.NCore.Client.Functions.V1.FunctionsAdapter(identity, new ClientSettings
                {
                    Address = GetFunctionsServiceAddress(),
                });
            }
            else
            {
                functionServiceServiceUrl = "services/Functions/V2/FunctionsService.svc";
                return new Gecko.NCore.Client.Functions.V2.FunctionsAdapter(identity, new ClientSettings
                {
                    Address = GetFunctionsServiceAddress(),
                });
            }
        }
    }
}
