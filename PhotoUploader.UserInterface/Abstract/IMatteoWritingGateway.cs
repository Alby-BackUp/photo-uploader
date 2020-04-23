using System;
using System.Threading.Tasks;
using PhotoUploader.UserInterface.Model;

namespace PhotoUploader.UserInterface.Abstract
{
    public interface IMatteoWritingGateway
    {
        Task Update(Image image);
        Task Create(Image image);
        Task Delete(Guid id);
    }
}
