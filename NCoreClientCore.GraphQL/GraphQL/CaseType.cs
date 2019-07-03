using Gecko.NCore.Client.ObjectModel.V3.En;
using GraphQL.Types;

namespace Api.GraphQL
{
    public class CaseType : ObjectGraphType<Case>
    {
        public CaseType()
        {
            Name = "Case";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Case.");
            Field(x => x.Title).Description("The title of the Case");
            Field(x => x.PublicTitle).Description("The public title of the Case");
            Field(x => x.AccessCodeId).Description("The access code id of the Case");
        }
    }
}