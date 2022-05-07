namespace BungieApiHelper.Entity.Unspecified.SingleComponentResponseOf {
    public abstract class SingleComponentResponseOf<T> where T : class {
        public T data { get; set; }
        public int privacy { get; set; }
        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        public bool? disabled { get; set; }
    }
}
