using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab_6_Consuming_Web_API
{
    public interface IHolidaysApiService
    {
        Task<List<HolidayModel>> GetHolidays(string countryCode, int year);
    }
}
