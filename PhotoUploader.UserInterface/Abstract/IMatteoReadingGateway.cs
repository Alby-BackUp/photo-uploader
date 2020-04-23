using System;
using System.Collections.Generic;
using PhotoUploader.UserInterface.Model;

namespace PhotoUploader.UserInterface.Abstract
{
    public interface IMatteoReadingGateway
    {
        IAsyncEnumerable<Service> ReadServices();
        IAsyncEnumerable<Image> ReadImagesPerService(Guid id);
    }
}