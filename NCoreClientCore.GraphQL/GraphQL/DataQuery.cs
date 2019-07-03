using System.Linq;
using Gecko.NCore.Client;
using Gecko.NCore.Client.ObjectModel.V3.En;
using GraphQL.Types;

namespace Api.GraphQL
{
    public class DataQuery : ObjectGraphType
    {
		public DataQuery(IEphorteContext dataContext)
        {

            Field<CaseType>(
              "Case",
              arguments: new QueryArguments(
                new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the Case." }),
              resolve: context =>
              {
                  var id = context.GetArgument<int>("id");
                  var c = dataContext.Query<Case>()
                    .FirstOrDefault(i => i.Id == id);
                  return c;
              });

            Field<ListGraphType<CaseType>>(
              "Cases",
              resolve: context =>
              {
                  var cases = dataContext.Query<Case>().Where(c => c.Id < 1000);
                  return cases;
              });
        }
    }
}