namespace SvtRoboticsLoaderApi.Models
{
    /// <summary>
    /// Represents an entity for robot
    /// </summary>
    public class Robot
    {
        /// <summary>
        /// Unique identifier for a robot
        /// </summary>
        public int RobotId { get; set; }

        /// <summary>
        /// Current battery percentage level
        /// </summary>
        public int BatteryLevel { get; set; }

        /// <summary>
        /// Current x-coordinate of a robot
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Current y-coordinate of a robot
        /// </summary>
        public int Y { get; set; }
    }
}
