using System.Windows.Forms;

namespace PhotoUploader.UserInterface.Services
{
    public class PipelineService
    {
        private readonly ComboBox _services;
        private readonly ComboBox _images;
        private readonly Button _open;
        private readonly Button _new;
        private readonly Button _upload;
        private readonly Button _delete;

        public PipelineService(ComboBox services, ComboBox images, Button open, Button @new, Button upload, Button delete)
        {
            _services = services;
            _images = images;
            _open = open;
            _new = @new;
            _upload = upload;
            _delete = delete;
        }

        public void ServiceSelected()
        {
            _services.Enabled = false;
            _open.Enabled = true;
        }

        public void PhotoSelected(int count)
        {
            _open.Enabled = false;
            _images.Enabled = count > 0;
            _new.Enabled = true;
        }

        public void ImageIdSelected(bool @new)
        {
            _new.Enabled = false;
            _images.Enabled = false;

            _upload.Enabled = true;
            _delete.Enabled = !@new;
        }

        public void OperationsCompleted()
        {
            _upload.Enabled = false;
            _delete.Enabled = false;
        }

        public void Reset()
        {
            _services.Enabled = true;
        }
    }
}
