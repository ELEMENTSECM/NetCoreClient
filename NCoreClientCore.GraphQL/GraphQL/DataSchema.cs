using GraphQL.Types;
using NCoreClientCore.NetStandard;

namespace Api.GraphQL
{

    public class DataSchema : Schema
    {
        public DataSchema(NCoreFactory factory)
        {
            Query = new DataQuery(factory.Create());
        }
    }
}