using PostOfficeIS.Models;
using PostOfficeIS.Services.City;
using PostOfficeIS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOfficeIS.Services.SendParcelService
{
    public class SendParcelService
    {
        public static bool CheckSendForm(SendParcelForm sendParcel)
        {
            foreach (Control control in sendParcel.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Заповніть всі поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if ((DateTime.Now - sendParcel.SndDatepck.Value).TotalDays <= 18 * 365 || (DateTime.Now - sendParcel.GtrDatepck.Value).TotalDays <= 18 * 365)
            {
                MessageBox.Show("Неправильно вказаний вік", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int p;
            if (!int.TryParse(sendParcel.SndPhonetxt.Text, out p) || !int.TryParse(sendParcel.SndPhonetxt.Text, out p))
            {
                return false;
            }
            if (CityService.CheckCity((sendParcel.Controls["SndCitytxt"] as TextBox).Text) == null)
            {
                MessageBox.Show("Такого міста не існує", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        public static List<ClientEntity> CreateClients(SendParcelForm sendParcel)
        {
            //////////////////////////Sender////////////////////////////////////////
            ClientEntity sender = new ClientEntity();
            ClientEntity geter = new ClientEntity();
            sender.Name = sendParcel.SndNametxt.Text;
            sender.Surname = sendParcel.SndSurnametxt.Text;
            sender.Phone = int.Parse(sendParcel.SndPhonetxt.Text);
            if (sendParcel.SndSwitcherswch.Checked)
            {
                sender.Gender = "Female";
            }
            else
            {
                sender.Gender = "Male";
            }
            sender.BirthDate = sendParcel.SndDatepck.Value.ToString();
            ///////////////////////Receiver////////////////////////////////
            geter.Name = sendParcel.GtrNametxt.Text;
            geter.Surname = sendParcel.GtrSurnametxt.Text;
            geter.Phone = int.Parse(sendParcel.GtrPhonetxt.Text);
            if (sendParcel.GtrSwitcherswch.Checked)
            {
                geter.Gender = "Female";
            }
            else
            {
                geter.Gender = "Male";
            }
            geter.BirthDate = sendParcel.GtrDatepck.Value.ToString();
            ///////////////////////Adding///////////////////////
            List<ClientEntity> clients = new List<ClientEntity>();
            clients.Add(sender);
            clients.Add(geter);
            MessageBox.Show("Данні успішно збережені", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return clients;
        }
    }
}
