using SvtRoboticsLoaderApi.Clients;
using SvtRoboticsLoaderApi.Models;
using SvtRoboticsLoaderApi.Processors.Interfaces;

namespace SvtRoboticsLoaderApi.Processors
{
    public class LoadProcessor : ILoadProcessor
    {
        private readonly IRobotService _robotService;

        public LoadProcessor(IRobotService robotService)
        {
            _robotService = robotService;
        }

        public async Task<LoaderOutput?> GetClosestAsync(Load load)
        {
            var robots = await _robotService.GetAllAsync();
            var distances = GetDistanceToLoad(load, robots?.ToList())
                .OrderBy(d => d.DistanceToGoal)
                .OrderByDescending(d => d.BatteryLevel);

            return distances.FirstOrDefault();
        }

        private List<LoaderOutput> GetDistanceToLoad(Load load, List<Robot>? robots)
        {
            var list = new List<LoaderOutput>();
            if (robots == null)
                return list;
            robots.ForEach(robot =>
            {
                list.Add(new LoaderOutput
                {
                    RobotId = robot.RobotId,
                    BatteryLevel = robot.BatteryLevel,
                    DistanceToGoal = Math.Round(ComputeDistance(load, robot), 2)
                });
            });

            return list;
        }

        private double ComputeDistance(Load load, Robot robot)
            => Math.Sqrt((load.X - robot.X) ^ 2 + (load.Y - robot.Y) ^ 2);
    }
}
