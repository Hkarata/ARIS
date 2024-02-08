var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.ARIS_Api>("apiservice");

builder.AddProject<Projects.ARIS>("aris")
    .WithReference(apiservice);

builder.Build().Run();
