using System.Text;
using System.Text.Json.Serialization;
using LAC.Core;
using LAC.Core.Extensions;
using LAC.Core.Types;
using LAC.Driver.Interfaces;
using LAC.Game.Apex.Core.Interfaces;

namespace LAC.Game.Apex.Core.Models
{
    public class LevelName : IUpdatable
    {
        private readonly Access<string> _value;

        #region Constructors

        public LevelName(IDriver driver, IOffsets offsets, ulong address)
        {
            _value = driver.Access(address + offsets.CoreLevelName, new StringType(32, Encoding.ASCII), 5000);
        }

        #endregion

        #region Properties

        [JsonPropertyName("value")]
        public string Value => _value.Get();

        #endregion

        #region Implementation of IUpdatable

        public void Update(DateTime frameTime)
        {
            _value.Update(frameTime);
        }

        #endregion
    }
}