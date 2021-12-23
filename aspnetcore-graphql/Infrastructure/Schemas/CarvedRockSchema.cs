﻿namespace Aspnetcore.Graphql.Infrastructure.Schemas
{
    using System;
    using GraphQL.Types;
    using Microsoft.Extensions.DependencyInjection;
    using Queries;

    public class CarvedRockSchema: Schema
    {
        public CarvedRockSchema(IServiceProvider serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<CarvedRockQuery>();

        }
        
    }
}