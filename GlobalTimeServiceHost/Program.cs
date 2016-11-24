using System;
using System.ServiceModel;
using GlobalTimeServices;

namespace GlobalTimeServiceHost
{
	class Program
	{
		private static ServiceHost host = null;

		static void StartService()
		{
			host = new ServiceHost(typeof(GlobalTimeService));
			host.Open();
		}

		static void StopService()
		{
			if(host.State!=CommunicationState.Closed)
				host.Close();
		}

		static void Main(string[] args)
		{
			StartService();
			Console.WriteLine("GlobalTimeService is started...");
			Console.ReadKey();
			StopService();
		}
	}
}
