using Microsoft.IdentityModel.Tokens;
using PostOfficeIS.Models;
using PostOfficeIS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDB.DB;

namespace PostOfficeIS.Services.ParcelSevice
{
    public class ParcelService
    {
        public static List<ParcelEntity> GetParcelsToCheck(string cityName)
        {
            using (var context = new MyDBContext())
            {
                var parcels = context.Transactions
                .Where(t => t.SenderCity.Name == cityName && t.PostManId == null)
                .Select(t => t.Parcel)
                .ToList();

                if (!parcels.IsNullOrEmpty())
                {
                    return parcels;
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool CheckFields(CheckParcelForm CHP)
        {
            foreach (Control control in CHP.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Заповніть всі поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            int p;
            if (!int.TryParse(CHP.Heighttxt.Text, out p) || !int.TryParse(CHP.Weighttxt.Text, out p))
            {
                return false;
            }
            return true;
        }
        public static void UpdateModel(ParcelEntity parcel)
        {
            using (var context = new MyDBContext())
            {
                context.Parcels.Update(parcel);
                context.SaveChanges();
                MessageBox.Show("Посилка оновилась", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

