using System;
using System.Linq;
using System.ServiceModel;
using GlobalTimeServiceInterfaces;

namespace JustTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Awaliable time zones:");
			foreach (var tzi in TimeZoneInfo.GetSystemTimeZones().Take(5))
			{
				Console.WriteLine(tzi.Id);
			}
			Console.WriteLine(TimeZoneInfo.Local.Id);
			using (ChannelFactory<IGlobalTimeService> proxy = 
				new ChannelFactory<IGlobalTimeService>("MyGlobalTimeServiceEndpoint"))
			{
				proxy.Open();
				var service = proxy.CreateChannel();

				var ekbId = "Ekaterinburg Standard Time";
				var alaskaId = "Alaskan Standard Time";
				Console.WriteLine("Current Time in Ekaterinburg: {0}", service.currentTime(ekbId));
				Console.WriteLine("Current Time in Alaska: {0}", service.currentTime(alaskaId));
				Console.WriteLine("Time in Ekaterinburg in 10 hours: {0}", service.plusHours(ekbId, 10));
				Console.WriteLine("Differce between Ekaterinburg and Alaska is {0}", service.timeBetween(ekbId, alaskaId));
				Console.WriteLine("12:05 in Ekaterinburg is {0} in Alaska", service.timeInGuestZone("12:05", ekbId, alaskaId));

				proxy.Close();
			}
		}
	}
}
