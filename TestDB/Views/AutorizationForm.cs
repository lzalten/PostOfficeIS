using MaterialSkin.Controls;
using PostOfficeIS.EntityFramework.Repository;
using PostOfficeIS.Models;
using PostOfficeIS.Services.WorkerProfile;
using PostOfficeIS.Services.WorkerService;
using PostOfficeIS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostOfficeIS.Views
{
    public partial class AutorizationForm : MaterialForm
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {

            bool status = WorkerService.CheckAutorizationForm(this);

            if (status != null)
            {
                WorkerProfileEntity wp = WorkerService.CheckWorker(this);
                if (wp != null)
                {
                    CheckParcelForm CPF = new CheckParcelForm(wp);
                    CPF.ShowDialog();
                }
            }
            else
                MessageBox.Show("eror", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
