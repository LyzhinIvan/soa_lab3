using System;

namespace GlobalTimeClient
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var client = new GlobalTimeServiceClient();
				var ekbId = "Ekaterinburg Standard Time";
				var alaskaId = "Alaskan Standard Time";
				Console.WriteLine("Current Time in Ekaterinburg: {0}", client.currentTime(ekbId));
				Console.WriteLine("Current Time in Alaska: {0}", client.currentTime(alaskaId));
				Console.WriteLine("Time in Ekaterinburg in 10 hours: {0}", client.plusHours(ekbId, 10));
				Console.WriteLine("Differce between Ekaterinburg and Alaska is {0}", client.timeBetween(ekbId, alaskaId));
				Console.WriteLine("12:05 in Ekaterinburg is {0} in Alaska", client.timeInGuestZone("12:05", ekbId, alaskaId));
				client.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
