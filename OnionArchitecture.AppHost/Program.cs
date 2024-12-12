var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.OnionArchitecture_ApiService>("apiservice");

builder.AddNpmApp("angular", "../OnionArchitecture.Web")
    .WithReference(apiService)
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints();

builder.Build().Run();
