using PostOfficeIS.Models;
using PostOfficeIS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDB.DB;

namespace PostOfficeIS.Services.WorkerService
{
    public class WorkerService
    {
        public static bool CheckAutorizationForm(AutorizationForm AF)
        {
            foreach (Control control in AF.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Заповніть всі поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public static WorkerProfileEntity CheckWorker(AutorizationForm AF)
        {
            using (var dbContext = new MyDBContext())
            {
                string enteredUsername = (AF.Controls["Logintxt"] as TextBox).Text;
                string enteredPassword = (AF.Controls["Passwordtxt"] as TextBox).Text;


                var worker = dbContext.Workers.FirstOrDefault(w => w.Username == enteredUsername && w.Password == enteredPassword);

                if (worker != null)
                {
                    //MessageBox.Show("знайдений worker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    var workerProfile = dbContext.WorkerProfiles.FirstOrDefault(wp => wp.WorkerId == worker.Id);

                    if (workerProfile != null)
                    {
                        return workerProfile;
                    }
                    else
                    {
                        //MessageBox.Show("не знайдений профіль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                else
                {
                    //MessageBox.Show("не знайдений воркер", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}
