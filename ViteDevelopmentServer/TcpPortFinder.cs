using System.Net.Sockets;
using System.Net;

namespace PrincipleStudios.ViteDevelopmentServer;

internal static class TcpPortFinder
{
	public static int FindAvailablePort()
	{
		using var listener = new TcpListener(IPAddress.Loopback, 0);
		listener.Start();
		try
		{
			return ((IPEndPoint)listener.LocalEndpoint).Port;
		}
		finally
		{
			listener.Stop();
		}
	}
}