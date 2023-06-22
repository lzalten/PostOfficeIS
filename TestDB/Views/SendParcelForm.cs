using MaterialSkin.Controls;
using PostOfficeIS.Models;
using PostOfficeIS.Services.City;
using PostOfficeIS.Services.ClientService;
using PostOfficeIS.Services.ParcelSevice;
using PostOfficeIS.Services.SendParcelService;
using TestDB.DB;

namespace PostOfficeIS.Views
{
    public partial class SendParcelForm : MaterialForm
    {
        public SendParcelForm()
        {
            InitializeComponent();
        }

        private void SendParcelForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendParcelbtn_Click(object sender, EventArgs e)
        {
            if (SendParcelService.CheckSendForm(this))
            {
                List<ClientEntity> clients = ClientService.CreateClients(this);
                ParcelEntity parcel = new ParcelEntity();
                CityEntity city = CityService.CheckCity(SndCitytxt.Text);

                TransactionEntity transaction = new TransactionEntity();
                transaction.Sender = clients[0];
                transaction.SenderCityId = city.Id;
                transaction.Geter = clients[1];
                transaction.Parcel = parcel;
                transaction.SendTime = DateTime.Now.ToString();


                using (MyDBContext _context = new MyDBContext())
                {
                    _context.Clients.Add(clients[0]);
                    _context.Clients.Add(clients[0]);
                    _context.Parcels.Add(parcel);
                    _context.Transactions.Add(transaction);
                    _context.SaveChanges();
                }
                ParcelPictureServicecs.CreatePicturesAsync(parcel.Id);
            }

        }
    }
}
