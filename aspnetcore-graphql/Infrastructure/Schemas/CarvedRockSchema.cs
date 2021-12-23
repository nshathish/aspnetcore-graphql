namespace Aspnetcore.Graphql.Infrastructure.Schemas
{
    using System;
    using GraphQL.Types;
    using Microsoft.Extensions.DependencyInjection;
    using Mutations;
    using Queries;

    public class CarvedRockSchema : Schema
    {
        public CarvedRockSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<CarvedRockQuery>();
            Mutation = serviceProvider.GetRequiredService<CarvedRockMutation>();
        }
    }
}