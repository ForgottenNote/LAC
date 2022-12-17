using Microsoft.Extensions.Configuration;

namespace LAC.Game.Apex.Feature.Spectators
{
    public class Config
    {
        private readonly IConfigurationSection _config;

        #region Constructors

        public Config(IConfiguration config)
        {
            _config = config.GetSection(typeof(Config).Namespace);
        }

        #endregion
    }
}