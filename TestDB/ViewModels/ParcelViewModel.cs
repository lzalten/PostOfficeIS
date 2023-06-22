using Microsoft.IdentityModel.Tokens;
using PostOfficeIS.Views;
namespace PostOfficeIS.ViewModels
{
    public class ParcelViewModel
    {
        //    public static List<Parcel> GetParcelsToCheck(string cityName)
        //    {
        //        using (var context = new MyDBContext())
        //        {
        //            var parcels = context.Transactions
        //            .Where(t => t.SenderCity.Name == cityName)
        //            .Select(t => t.Parcel)
        //            .ToList();

        //            if (!parcels.IsNullOrEmpty())
        //            {
        //                return parcels;
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //    }
        //    public static bool CheckFields(CheckParcelForm CHP)
        //    {
        //        foreach (Control control in CHP.Controls)
        //        {
        //            if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
        //            {
        //                MessageBox.Show("Заповніть всі поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }

        //        int p;
        //        if (!int.TryParse(CHP.Heighttxt.Text, out p) || !int.TryParse(CHP.Weighttxt.Text, out p))
        //        {
        //            return false;
        //        }
        //        return true;
        //    }
        //    public static void UpdateModel(Parcel parcel)
        //    {
        //        using (var context = new MyDBContext())
        //        {
        //            context.Parcels.Update(parcel);
        //            context.SaveChanges();
        //            MessageBox.Show("Посилка оновилась", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }
        //}
    }
}
