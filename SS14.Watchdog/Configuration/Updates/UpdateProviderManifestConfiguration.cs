namespace SS14.Watchdog.Configuration.Updates
{
    public class UpdateProviderManifestConfiguration
    {
        public string ManifestUrl { get; set; } = null!;

        /// <summary>
        /// If set, will pass HTTP auth username when trying to download the server zip
        /// </summary>
        /// <value></value>
        public string? ServerDownloadUsername { get; set; }

        /// <summary>
        /// If set, will pass HTTP auth password when trying to download the server zip
        /// </summary>
        /// <value></value>
        public string? ServerDownloadPassword { get; set; }
    }
}
