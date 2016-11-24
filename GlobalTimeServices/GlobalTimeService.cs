using System;
using System.Globalization;
using GlobalTimeServiceInterfaces;

namespace GlobalTimeServices
{
	public class GlobalTimeService : IGlobalTimeService
	{
		/// <summary>
		/// Возвращает текущее время в указанном часовом поясе
		/// </summary>
		/// <param name="timeZone">Часовой пояс</param>
		/// <returns>Время в формате hh:mm</returns>
		public string currentTime(string timeZone)
		{
			return TryExec(() =>
			{
				var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
				var time = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
				return time.ToString("t", CultureInfo.InvariantCulture);
			});
		}

		/// <summary>
		/// Возвращает время в guestTimeZone относительно указанного времени в homeTimeZone. 
		/// Например указываем время 12:00 по Челябинску, просим показать время по Москве, получаем 10:00
		/// </summary>
		/// <param name="time">Время в домашней зоне в формате hh:mm</param>
		/// <param name="homeTimeZone">Домашний часовой пояс</param>
		/// <param name="guestTimeZone">Гостевой часовой пояс</param>
		/// <returns>Время в гостевой зоне в формате hh:mm</returns>
		public string timeInGuestZone(string time, string homeTimeZone, string guestTimeZone)
		{
			return TryExec(() =>
			{
				var dateTime = DateTime.ParseExact(time, "t", CultureInfo.InvariantCulture);
				var homeTZI = TimeZoneInfo.FindSystemTimeZoneById(homeTimeZone);
				var guestTZI = TimeZoneInfo.FindSystemTimeZoneById(guestTimeZone);
				var guestDateTime = TimeZoneInfo.ConvertTime(dateTime, homeTZI, guestTZI);
				return guestDateTime.ToString("t", CultureInfo.InvariantCulture);
			});
		}

		/// <summary>
		/// Возвращает дату и время которой будет в указанном часовом поясе через указанное количество часов.
		/// </summary>
		/// <param name="timeZone">Часовой пояс</param>
		/// <param name="hoursCount">Количество часов</param>
		/// <returns>Время в формате hh:mm</returns>
		public string plusHours(string timeZone, int hoursCount)
		{
			return TryExec(() =>
			{
				var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
				var dateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
				dateTime = dateTime.AddHours(hoursCount);
				return dateTime.ToString("t", CultureInfo.InvariantCulture);
			});
		}

		/// <summary>
		/// Возвращает разницу во времени между часовыми поясами.
		/// </summary>
		/// <param name="firstTimeZone">Первый часовой пояс</param>
		/// <param name="secondTimeZone">Второй часовой пояс</param>
		/// <returns>Разница во времени в формате hh:mm</returns>
		public string timeBetween(string firstTimeZone, string secondTimeZone)
		{
			return TryExec(() =>
			{
				var firstTZI = TimeZoneInfo.FindSystemTimeZoneById(firstTimeZone);
				var secondTZI = TimeZoneInfo.FindSystemTimeZoneById(secondTimeZone);
				TimeSpan diff = secondTZI.BaseUtcOffset - firstTZI.BaseUtcOffset;
				return $"{diff.Hours:D2}:{diff.Minutes:D2}";
			});
		}

		private string TryExec(Func<string> func)
		{
			try
			{
				return func();
			}
			catch (ArgumentNullException)
			{
				return "timezone cannot be null";
			}
			catch (TimeZoneNotFoundException)
			{
				return "timezone not found";
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
				return "server error";
			}
		}
	}
}
