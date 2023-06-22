using PostOfficeIS.Models;
using PostOfficeIS.ViewModels;
using TestDB.DB;

namespace PostOfficeIS.Services.City
{
    public class CityService
    {
        public static CityEntity CheckCity(string name)
        {
            using (var context = new MyDBContext())
            {
                return context.Cities.FirstOrDefault(c => c.Name == name);
            }
        }
        public static string GetCityByWorkerProfile(int wpId)
        {


            using (var context = new MyDBContext())
            {
                var cityName = (from workerProfile in context.WorkerProfiles
                                join postOffice in context.PostOffices on workerProfile.PostOfficeId equals postOffice.Id
                                join city in context.Cities on postOffice.CityId equals city.Id
                                where workerProfile.Id == wpId
                                select city.Name).FirstOrDefault();

                return cityName;
            }
        }

    }
}
