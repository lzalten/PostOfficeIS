
using PostOfficeIS.Models;
using PostOfficeIS.ViewModels;
using PostOfficeIS.Views;

namespace PostOfficeIS.Services.WorkerProfile
{
    public interface IWorkerProfileService
    {
        public WorkerProfileViewModel CheckWorker(string login, string password);
        public WorkerProfileViewModel ConvertModels(WorkerProfileEntity wp);

    }
}
