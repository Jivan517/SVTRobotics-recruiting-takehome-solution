namespace SvtRoboticsLoaderApi.Models
{
    /// <summary>
    /// Represents an entity containing load to robot distance in a Cartesian plane
    /// </summary>
    public class LoaderOutput
    {
        /// <summary>
        /// Unique identifier for a robot
        /// </summary>
        public int RobotId { get; set; }
        
        /// <summary>
        /// Indicates how far the robot is from the load which needs to be moved.
        /// </summary>
        public double DistanceToGoal { get; set; }

        /// <summary>
        /// Current battery percentage level
        /// </summary>
        public int BatteryLevel { get; set; }
    }
}
