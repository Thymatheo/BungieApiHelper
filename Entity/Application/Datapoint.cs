using System;

namespace BungieApiHelper.Entity.Application
{
    public class Datapoint
    {
        /// <summary>
        /// Timestamp for the related count.
        /// </summary>
        public DateTime time;
        /// <summary>
        /// Count associated with timestamp
        /// </summary>
        public double? count;
    }
}