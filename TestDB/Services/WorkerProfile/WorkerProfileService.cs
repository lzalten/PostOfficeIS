using PostOfficeIS.Core.Interfaces;
using PostOfficeIS.Models;
using PostOfficeIS.ViewModels;
using PostOfficeIS.Views;

namespace PostOfficeIS.Services.WorkerProfile
{
    public class WorkerProfileService : IWorkerProfileService
    {
        private readonly IRepository<WorkerProfileEntity> _workerProfileRepository;

        public WorkerProfileService(IRepository<WorkerProfileEntity> workerProfileRepository)
        {
            _workerProfileRepository = workerProfileRepository;
        }

        public WorkerProfileViewModel CheckWorker(string login, string password)
        {
            var workerProfileEntity = _workerProfileRepository.Get(e => e.Worker.Username == login && e.Worker.Password == password).FirstOrDefault();

            if (workerProfileEntity != null)
            {
                MessageBox.Show("Успішна авторизація", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ConvertModels(workerProfileEntity);
            }
            else
            {
                MessageBox.Show("Невірний логін чи пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public WorkerProfileViewModel ConvertModels(WorkerProfileEntity wp)
        {
            WorkerProfileViewModel viewModel = new WorkerProfileViewModel();
            viewModel.Name = wp.Name;
            viewModel.Surname = wp.Surname;
            viewModel.Gender = wp.Gender;
            viewModel.BirthDate = wp.BirthDate;
            viewModel.Phone = wp.Phone;
            return viewModel;

        }
    }
}