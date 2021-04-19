using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Nasa : Form
    {
        public Nasa()
        {
            InitializeComponent();
        }

        void buttonPOTD_Click(object sender, EventArgs e)
        {
            try
            {
                POTD potd = new POTD(NasaPOTD.Get(datePOTD.Value.Date));
                potd.Show();
            }
            catch
            {
                MessageBox.Show("No data");
            }
        }

        void buttonMRP_Click(object sender, EventArgs e)
        {
            try
            {
                MRP mrp = new MRP(NasaMRP.Get(datePOTD.Value.Date));
                mrp.Show();
            }
            catch
            {
                MessageBox.Show("No data");
            }
        }
    }
}
