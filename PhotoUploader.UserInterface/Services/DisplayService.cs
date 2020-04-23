using System.Windows.Forms;

namespace PhotoUploader.UserInterface.Services
{
    public class DisplayService
    {
        private readonly RichTextBox _display;

        public DisplayService(RichTextBox display)
        {
            _display = display;
        }

        public void Print(string text) => _display.Text = text;

        public void Append(string text) => _display.Text += $"{text} \n\r";

        public void Clear() => _display.Text = string.Empty;

        public string Text => _display.Text;
    }
}
