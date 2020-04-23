using System;
using PhotoUploader.UserInterface.Abstract;

namespace PhotoUploader.UserInterface.Model
{
    public class Service : IEntity
    {
        public Service(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }
    }
}
