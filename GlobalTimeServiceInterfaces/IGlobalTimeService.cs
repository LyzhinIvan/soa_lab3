using System.ServiceModel;

namespace GlobalTimeServiceInterfaces
{
	[ServiceContract]
    public interface IGlobalTimeService
    {
		/// <summary>
		/// Возвращает текущее время в указанном часовом поясе
		/// </summary>
		/// <param name="timeZone">Часовой пояс</param>
		/// <returns>Время в формате hh:mm</returns>
		[OperationContract]
		string currentTime(string timeZone);

		/// <summary>
		/// Возвращает время в guestTimeZone относительно указанного времени в homeTimeZone. 
		/// Например указываем время 12:00 по Челябинску, просим показать время по Москве, получаем 10:00
		/// </summary>
		/// <param name="time">Время в домашней зоне в формате hh:mm</param>
		/// <param name="homeTimeZone">Домашний часовой пояс</param>
		/// <param name="guestTimeZone">Гостевой часовой пояс</param>
		/// <returns>Время в гостевой зоне в формате hh:mm</returns>
		[OperationContract]
		string timeInGuestZone(string time, string homeTimeZone, string guestTimeZone);

		/// <summary>
		/// Возвращает дату и время которой будет в указанном часовом поясе через указанное количество часов.
		/// </summary>
		/// <param name="timeZone">Часовой пояс</param>
		/// <param name="hoursCount">Количество часов</param>
		/// <returns>Время в формате hh:mm</returns>
		[OperationContract]
		string plusHours(string timeZone, int hoursCount);

		/// <summary>
		/// Возвращает разницу во времени между часовыми поясами.
		/// </summary>
		/// <param name="firstTimeZone">Первый часовой пояс</param>
		/// <param name="secondTimeZone">Второй часовой пояс</param>
		/// <returns>Разница во времени в формате hh:mm</returns>
		[OperationContract]
		string timeBetween(string firstTimeZone, string secondTimeZone);
    }
}
