var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CodeLab_InBoxPattern_Api>("codelab-inboxpattern-api");

builder.Build().Run();
