using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PhotoUploader.UserInterface.Abstract;

namespace PhotoUploader.UserInterface.Services
{
    public class ComboboxService<T> where T : IEntity
    {
        private readonly ComboBox _combobox;

        public ComboboxService(ComboBox combobox, IEnumerable<T> services)
        {
            _combobox = combobox;

            Initialize(services);
        }

        public bool Enabled
        {
            get => _combobox.Enabled;
            set => _combobox.Enabled = value;
        }

        private void Initialize(IEnumerable<T> services)
        {
            Enabled = false;

            _combobox.DataSource = services;

            _combobox.DisplayMember = "Name";
            _combobox.ValueMember = "Id";

            Enabled = true;
        }

        public void SelectedIndexChanged(Action<object> action) => _combobox.SelectedIndexChanged += (e, _) => action(e);
    }
}
