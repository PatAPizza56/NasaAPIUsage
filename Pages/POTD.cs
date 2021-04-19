using System.Windows.Forms;

namespace Project
{
    public partial class POTD : Form
    {
        public POTD(NasaPOTD.NasaPOTDResponse response)
        {
            InitializeComponent();

            pictureURL.Load(response.url);
            labelExplanation.Text = response.explanation;
        }
    }
}
