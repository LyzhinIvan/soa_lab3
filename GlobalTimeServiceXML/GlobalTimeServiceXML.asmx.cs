using System.Web.Services;
using GlobalTimeServiceInterfaces;
using GlobalTimeServices;

namespace GlobalTimeServiceXML
{
	/// <summary>
	/// Global Time Service
	/// </summary>
	[WebService(Namespace = "http://localhost/GlobalTimeService", Description = "Service with methods for working with global time")]
	public class GlobalTimeServiceXML : System.Web.Services.WebService
	{
		IGlobalTimeService gtService = new GlobalTimeService();
		
		[WebMethod(Description = "Возвращает текущее время в указанном часовом поясе.")]
		public string CurrentTime(string timeZone)
		{
			return gtService.currentTime(timeZone);
		}

		[WebMethod(Description = "Возвращает время в guestTimeZone относительно указанного времени в homeTimeZone. " +
		                         "Например указываем время 12:00 по Челябинску, просим показать время по Москве, получаем 10:00.")]
		public string TimeInGuestZone(string time, string homeTimeZone, string guestTimeZone)
		{
			return gtService.timeInGuestZone(time, homeTimeZone, guestTimeZone);
		}

		[WebMethod(Description = "Возвращает дату и время которой будет в указанном часовом поясе через указанное количество часов.")]
		public string PlusHours(string timeZone, int hoursCount)
		{
			return gtService.plusHours(timeZone, hoursCount);
		}

		[WebMethod(Description = "Возвращает разницу во времени между часовыми поясами.")]
		public string TimeBetween(string firstTimeZone, string secondTimeZone)
		{
			return gtService.timeBetween(firstTimeZone, secondTimeZone);
		}
	}
}
