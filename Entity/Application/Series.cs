namespace BungieApiHelper.Entity.Application
{
    public class Series
    {
        /// <summary>
        /// Collection of samples with time and value.
        /// </summary>
        public Datapoint[] datapoints;
        /// <summary>
        /// Target to which to datapoints apply.
        /// </summary>
        public string target;
    }
}