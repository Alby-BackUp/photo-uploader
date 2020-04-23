using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PhotoUploader.UserInterface.Abstract;
using PhotoUploader.UserInterface.Model;
using PhotoUploader.UserInterface.Services;

namespace PhotoUploader.UserInterface
{
    public partial class Main : Form
    {
        private readonly IMatteoReadingGateway _readingGateway;
        private readonly IMatteoWritingGateway _writingGateway;

        private readonly State _state;
        private DisplayService _display;
        private PipelineService _pipeline;

        public Main(IMatteoWritingGateway writingGateway, IMatteoReadingGateway readingGateway, State state)
        {
            _writingGateway = writingGateway;
            _readingGateway = readingGateway;
            _state = state;

            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            _display = new DisplayService(rtb_errors);

            _pipeline = new PipelineService(cmb_services, cmb_image_id, btn_open, btn_create, btn_upload, btn_delete);

            var services = await _readingGateway.ReadServices().ToListAsync();

            var servicesCombo = new ComboboxService<Service>(cmb_services, services);
            servicesCombo.SelectedIndexChanged(sender =>
            {
                var combo = (ComboBox) sender;

                _state.Service = (Service) combo.SelectedItem;
                _display.Append($"You have selected {_state.Service.Name}.");
                _pipeline.ServiceSelected();
            });
        }

        private async void btn_open_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            var result = dlg.ShowDialog();

            if (result != DialogResult.OK || string.IsNullOrEmpty(dlg.SafeFileName)) return;

            var images = await _readingGateway.ReadImagesPerService(_state.Service.Id).ToListAsync();
            var imagesCombo = new ComboboxService<Image>(cmb_image_id, images);
            imagesCombo.SelectedIndexChanged(sender =>
            {
                var combo = (ComboBox) sender;

                var imageId = (Guid) combo.SelectedValue;

                _state.New = false;
                _state.Image.RenewId(imageId);

                _display.Append($"You have selected {_state.Image.Name}{_state.Image.Extension}. With guid: {_state.Image.Id}");
                _pipeline.ImageIdSelected(_state.New);
            });

            var file = dlg.FileName;
            var name = Path.GetFileNameWithoutExtension(file);
            var extension = Path.GetExtension(file);

            var photo = await File.ReadAllBytesAsync(file);
            var image = new Image(name, extension, _state.Service.Id, photo);

            _state.Image = image;
            _display.Append($"You have selected {file}.");

            _pipeline.PhotoSelected(images.Count);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            _state.New = true;
            _state.Image.RenewId(Guid.NewGuid());

            _display.Append($"New guid was generated: {_state.Image.Id}");
            _pipeline.ImageIdSelected(_state.New);
        }

        private async void btn_upload_Click(object sender, EventArgs e)
        {
            if (_state.New)
                await _writingGateway.Create(_state.Image);
            else
                await _writingGateway.Update(_state.Image);

            _display.Append("Image uploaded!");
            _display.Append("Press reset for another processing");

            _pipeline.OperationsCompleted();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            await _writingGateway.Delete(_state.Image.Id);

            _display.Append("Image deleted!");
            _display.Append("Press reset for another processing");

            _pipeline.OperationsCompleted();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            _pipeline.Reset();
            _display.Clear();
        }
    }
}
