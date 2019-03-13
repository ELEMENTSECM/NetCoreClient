#if DEBUG
//#define USE_LOCAL_NCORE
#define FUNCTIONS_V1
//using Gecko.NCore.Client.Functions.V1;

namespace NCoreClientCore.NetStandard
{
    public class NCoreOptions
    {
        public string NCoreBaseAddress { get; set; }
        public string FunctionServiceVersion { get; set; } = "v1";

        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public string Role { get; set; }
        public string ExternalSystemName { get; set; } = "ephorteweb";
    }

}
#endif
