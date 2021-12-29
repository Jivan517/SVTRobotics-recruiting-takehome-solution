namespace SvtRoboticsLoaderApi.Models
{
    /// <summary>
    /// Represents an entity which a robot has to move
    /// </summary>
    public class Load
    {
        /// <summary>
        /// Unique identifier for a load
        /// </summary>
        public int LoadId { get; set; }

        /// <summary>
        /// Current x-coordinate of a load
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Current y-coordinate of a load
        /// </summary>
        public int Y { get; set; }
    }
}
