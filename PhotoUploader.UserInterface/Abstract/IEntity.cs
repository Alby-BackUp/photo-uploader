using System;

namespace PhotoUploader.UserInterface.Abstract
{
    public interface IEntity
    {
        public Guid Id { get; }
        public string Name { get; }
    }
}
