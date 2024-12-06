var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ActCourse_Backend>("actcourse-backend");

builder.Build().Run();
