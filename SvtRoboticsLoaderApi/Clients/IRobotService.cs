using SvtRoboticsLoaderApi.Models;

namespace SvtRoboticsLoaderApi.Clients
{
    public interface IRobotService
    {
        Task<IEnumerable<Robot>?> GetAllAsync();
    }
}
