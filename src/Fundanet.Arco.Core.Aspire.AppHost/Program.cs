using Microsoft.Extensions.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder
    .AddPostgres("postgres")
    .AddDatabase("AspirationalAbp");

var redis = builder.AddRedis("redis");

// DbMigrator  
if (builder.Environment.IsDevelopment())
{
    builder
        .AddProject<Projects.Fundanet_Arco_Core_Aspire_DbMigrator>("dbMigrator")
        .WithReference(postgres, "Default")
        .WithReference(redis, "Redis")
        .WithReplicas(1);
}

builder
    .AddProject<Projects.Fundanet_Arco_Core_Aspire_Blazor>("web", "Fundanet.Arco.Core.Aspire.Blazor")
    .WithReference(redis);

builder.Build().Run();
