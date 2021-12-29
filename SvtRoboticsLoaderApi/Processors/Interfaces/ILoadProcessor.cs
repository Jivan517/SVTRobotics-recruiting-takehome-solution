using SvtRoboticsLoaderApi.Models;

namespace SvtRoboticsLoaderApi.Processors.Interfaces
{
    public interface ILoadProcessor
    {
        Task<LoaderOutput?> GetClosestAsync(Load load);
    }
}
