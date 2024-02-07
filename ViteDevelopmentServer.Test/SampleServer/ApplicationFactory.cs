using Microsoft.AspNetCore.Mvc.Testing;
using PrincipleStudios.ViteDevelopmentServer;
using PrincipleStudios.ViteDevelopmentServer.Demo;

namespace PrincipleStudios.SampleServer;

public class ApplicationFactory : WebApplicationFactory<Startup>
{
	public ApplicationFactory()
	{
		// Ensure the working directory is set to the Demo directory; this is where the app expects to run under normal debugging
		Directory.SetCurrentDirectory(
			Path.GetFullPath(
				"ViteDevelopmentServer.Demo",
				SolutionUtils.GetSolutionDirectory(Directory.GetCurrentDirectory(), "PrincipleStudios.NodeDevTools.sln")
			)
		);
	}
}
