using MaterialSkin.Controls;
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
    public partial class MenuForm : MaterialForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void SendParcelbtn_Click(object sender, EventArgs e)
        {
            SendParcelForm SPF = new SendParcelForm();
            SPF.ShowDialog();
        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            AutorizationForm SIF = new AutorizationForm();
            SIF.ShowDialog();
        }

        private void ReceiveParcelbtn_Click(object sender, EventArgs e)
        {
            ReceiveParcel rcp = new ReceiveParcel();
            rcp.ShowDialog();
        }
    }
}
