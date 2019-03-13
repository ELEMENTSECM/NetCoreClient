using Gecko.NCore.Client;
using System;
using System.Linq;
using Gecko.NCore.Client.ObjectModel.V3.En;
using Gecko.NCore.Client.Querying;


namespace NCoreClientCore.NetStandard
{
    public class Oms
    {
        private readonly Action<string> _log;

        static IEphorteContext EphorteContext { get; set; }

        public Oms(Action<string> logInformation, NCoreFactory nCoreFactory)
        {
            _log = logInformation
                ?? throw new ArgumentNullException(nameof(logInformation));
            EphorteContext = nCoreFactory.Create();
        }

        public void LogCases()
        {
            try
            {
                var caseDetail = (from c in EphorteContext.Query<Case>().Include(x => x.OfficerName)
                                  where c.Id > 10
                                  select c).Take(40);

                foreach (var @case in caseDetail)
                {
                    _log($"Case: {@case.Id} - {@case.Title}");
                }
            }
            catch (Exception ex)
            {
                _log($"Error: {ex.Message}");
            }
        }

        public void LogSupportedFunctions()
        {
            try
            {
                var functions = EphorteContext.Functions.SupportedFunctions;
                foreach (var descriptor in functions)
                {
                    _log(descriptor.Name);
                }
            }
            catch (Exception ex)
            {

                _log($"Error: {ex.Message}");
            }
        }

        public void FetchDocument(int registryEntryId)
        {
            try
            {
                using (var stream = EphorteContext.Documents.OpenByRegistryEntryId(registryEntryId))
                {
                    _log($"Length of document fetched RegistryEntry with id {registryEntryId}: {stream.Length}");
                }
            }
            catch (Exception ex)
            {
                _log($"Failed to get document for RegistryEntry with id {registryEntryId}: {Environment.NewLine}{ex.Message}");
            }
        }
    }
}
