var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorWebExamples>("blazorwebexamples");

builder.Build().Run();
