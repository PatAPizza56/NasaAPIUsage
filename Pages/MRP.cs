using System.Windows.Forms;

namespace Project
{
    public partial class MRP : Form
    {
        public MRP(NasaMRP.NasaMRPResponse response)
        {
            InitializeComponent();

            pictureURL.Load(response.photos[0].img_src);
            labelCameraName.Text = response.photos[0].camera.full_name;
        }
    }
}
