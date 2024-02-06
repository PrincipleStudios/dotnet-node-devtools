using Microsoft.AspNetCore.TestHost;
using PrincipleStudios.SampleServer;

namespace PrincipleStudios.ViteDevelopmentServer;

public class ViteServerShould
	: IClassFixture<ApplicationFactory>
{
	private readonly ApplicationFactory _factory;

	public ViteServerShould(ApplicationFactory factory)
	{
		_factory = factory;
	}

	[Theory]
	[InlineData("/", "text/html")]
	[InlineData("/Index", "text/html")]
	[InlineData("/About", "text/html")]
	[InlineData("/Privacy", "text/html")]
	[InlineData("/Contact", "text/html")]
	// The following file is for dev mode only; Vite should transpile the file on the fly
	[InlineData("/src/main.tsx", "application/javascript")]
	public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string path, string contentType)
	{
		// Arrange
		var client = _factory
			.WithWebHostBuilder(builder => builder.UseSolutionRelativeContentRoot("ViteDevelopmentServer.Demo"))
			.CreateClient();

		// Act
		var response = await client.GetAsync(path);

		// Assert
		response.EnsureSuccessStatusCode(); // Status Code 200-299
		Assert.Equal(contentType, response.Content.Headers.ContentType?.MediaType);
	}

}
