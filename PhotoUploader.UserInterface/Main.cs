using System;
using System.IO;
using System.Windows.Forms;
using PhotoUploader.UserInterface.Gateways;

namespace PhotoUploader.UserInterface
{
    public partial class Main : Form
    {
        private readonly IMatteoWritingGateway _gateway;

        public Main(IMatteoWritingGateway gateway)
        {
            _gateway = gateway;
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            lbl_result.Text = string.Empty;

            var id = rtb_service_id.Text;
            var photo = File.ReadAllBytes(rtb_photo_path.Text);

            _gateway.Write(id, photo);

            lbl_result.Text = "Done";
        }
    }
}
