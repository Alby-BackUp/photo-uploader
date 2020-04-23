using System;

namespace PhotoUploader.UserInterface.Model
{
    public class State
    {
        public Service Service { get; set; }
        public Image Image { get; set; }
        public bool New { get; set; }
    }
}
