using System;
using PhotoUploader.UserInterface.Abstract;

namespace PhotoUploader.UserInterface.Model
{
    public class Image : IEntity
    {
        public Image(Guid id, string name, string extension, Guid serviceId, byte[] stream = null)
        {
            Id = id;
            Name = name;
            Extension = extension;
            ServiceId = serviceId;
            Stream = stream;
        }

        public Image(string name, string extension, Guid serviceId,  byte[] stream = null) : this(Guid.Empty, name, extension, serviceId, stream)
        {
        }

        public string Extension { get; }
        public Guid ServiceId { get; }
        public byte[] Stream { get; }

        public Guid Id { get; private set; }
        public string Name { get; }

        public void RenewId(Guid id) => Id = id;
    }
}
