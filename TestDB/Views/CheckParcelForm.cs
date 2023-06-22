using MaterialSkin.Controls;
using PostOfficeIS.Models;
using PostOfficeIS.Services.City;
using PostOfficeIS.Services.ParcelSevice;
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
using TestDB.DB;

namespace PostOfficeIS.Views
{
    public partial class CheckParcelForm : MaterialForm
    {
        int Height;
        int Width;
        string Name;
        bool Fragility;
        List<ParcelEntity> parcels;
        ParcelEntity curentParcel;
        int curentParcelNum;
        WorkerProfileEntity workerProfile;
        public CheckParcelForm()
        {
            InitializeComponent();
        }
        public CheckParcelForm(WorkerProfileEntity wp)
        {
            workerProfile = wp;
            InitializeComponent();
        }

        private void CheckParcelForm_Load(object sender, EventArgs e)
        {
            var cityName = CityService.GetCityByWorkerProfile(workerProfile.Id);
            if (ParcelService.GetParcelsToCheck(cityName) == null)
            {
                MessageBox.Show("Немає посилок", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Confirmbtn.Enabled = false;
                Heighttxt.Enabled = false;
                Weighttxt.Enabled = false;
                Nametxt.Enabled = false;
            }
            else
            {
                parcels = ParcelService.GetParcelsToCheck(cityName);
                curentParcel = parcels.FirstOrDefault();
                //Heighttxt.Text = curentParcel.Height.ToString();
                //Weighttxt.Text = curentParcel.Width.ToString();
                label5.Text = curentParcel.Id.ToString();
                string fileName = $"C:\\Users\\ммм\\source\\repos\\TestDB\\TestDB\\ParcelsImg\\{label5.Text}.png";
                if (File.Exists(fileName))
                {
                    pictureBox1.Image = Image.FromFile(fileName);
                }
                if (parcels.Count == 1)
                {
                    Nextbtn.Enabled = false;
                }
                Previousbtn.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            if (ParcelService.CheckFields(this))
            {
                Width = int.Parse(Weighttxt.Text);
                Height = int.Parse(Heighttxt.Text);
                Name = Nametxt.Text;
                curentParcel.Name = Name;
                curentParcel.Fragility = Frangilitybtn.Checked;
                curentParcel.Height = Height;
                curentParcel.Width = Width;
                ParcelService.UpdateModel(curentParcel);
                using (var context =new MyDBContext())
                {
                    TransactionEntity transaction = context.Transactions.FirstOrDefault(t => t.ParcelId == curentParcel.Id);
                    transaction.CheckTime = DateTime.Now.ToString();
                    transaction.PostMan = workerProfile;
                    context.Transactions.Update(transaction);
                    context.SaveChanges();
                    MessageBox.Show("Посилка перевірилась", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            CheckParcelForm_Load(sender,e);
        }

        private void Previousbtn_Click(object sender, EventArgs e)
        {
            if (curentParcelNum == 1)
            {
                Previousbtn.Enabled = false;
                Nextbtn.Enabled = true;
                curentParcelNum--;
                curentParcel = parcels[0];
                //Heighttxt.Text = curentParcel.Height.ToString();
                //Weighttxt.Text = curentParcel.Width.ToString();
                //Nametxt.Text = curentParcel.Name.ToString();
                label5.Text = curentParcel.Id.ToString();
                string fileName = $"C:\\Users\\ммм\\source\\repos\\TestDB\\TestDB\\ParcelsImg\\{label5.Text}.png";
                if (File.Exists(fileName))
                {
                    pictureBox1.Image = Image.FromFile(fileName);
                }
            }
            else
            {
                Nextbtn.Enabled = true;
                curentParcelNum--;
                curentParcel = parcels[curentParcelNum];
                //Heighttxt.Text = curentParcel.Height.ToString();
                //Weighttxt.Text = curentParcel.Width.ToString();
                //Nametxt.Text = curentParcel.Name.ToString();
                label5.Text = curentParcel.Id.ToString();
                string fileName = $"C:\\Users\\ммм\\source\\repos\\TestDB\\TestDB\\ParcelsImg\\{label5.Text}.png";
                if (File.Exists(fileName))
                {
                    pictureBox1.Image = Image.FromFile(fileName);
                }
            }
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (curentParcelNum == parcels.Count - 2)
            {
                Previousbtn.Enabled = true;
                Nextbtn.Enabled = false;
                curentParcelNum++;
                curentParcel = parcels[parcels.Count - 1];
                //Heighttxt.Text = curentParcel.Height.ToString();
                //Weighttxt.Text = curentParcel.Width.ToString();
                //Nametxt.Text = curentParcel.Name.ToString();
                label5.Text = curentParcel.Id.ToString();
                string fileName = $"C:\\Users\\ммм\\source\\repos\\TestDB\\TestDB\\ParcelsImg\\{label5.Text}.png";
                if (File.Exists(fileName))
                {
                    pictureBox1.Image = Image.FromFile(fileName);
                }
            }
            else
            {
                Previousbtn.Enabled = true;
                curentParcelNum++;
                curentParcel = parcels[curentParcelNum];
                //Heighttxt.Text = curentParcel.Height.ToString();
                //Weighttxt.Text = curentParcel.Width.ToString();
                //Nametxt.Text = curentParcel.Name.ToString();
                label5.Text = curentParcel.Id.ToString();
                string fileName = $"C:\\Users\\ммм\\source\\repos\\TestDB\\TestDB\\ParcelsImg\\{label5.Text}.png";
                if (File.Exists(fileName))
                {
                    pictureBox1.Image = Image.FromFile(fileName);
                }
            }
        }
    }
}
