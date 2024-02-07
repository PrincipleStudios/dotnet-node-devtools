using PrincipleStudios.ViteDevelopmentServer.Demo;

Host.CreateDefaultBuilder(args)
	.ConfigureWebHostDefaults(webBuilder =>
	{
		webBuilder.UseStartup<Startup>();
	})
	.Build()
	.Run();
