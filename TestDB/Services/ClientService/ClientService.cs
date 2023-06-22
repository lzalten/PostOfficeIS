using PostOfficeIS.Models;
using PostOfficeIS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOfficeIS.Services.ClientService
{
    public class ClientService
    {
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
