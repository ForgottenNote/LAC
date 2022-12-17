using System.Text.Json.Serialization;
using LAC.Core;
using LAC.Core.Extensions;
using LAC.Core.Types;
using LAC.Driver.Interfaces;
using LAC.Game.Apex.Core.Interfaces;

namespace LAC.Game.Apex.Core.Models
{
    public class Entity : IUpdatable
    {
        private readonly Access<ulong> _signifierName;

        #region Constructors

        public Entity(IDriver driver, IOffsets offsets, ulong address)
        {
            _signifierName = driver.Access(address + offsets.EntitySignifierName, UInt64Type.Instance, 60000);
        }

        #endregion

        #region Properties

        [JsonPropertyName("signifierName")]
        public ulong SignifierName
        {
            get => _signifierName.Get();
            set => _signifierName.Set(value);
        }

        #endregion

        #region Implementation of IUpdatable

        public void Update(DateTime frameTime)
        {
            _signifierName.Update(frameTime);
        }

        #endregion
    }
}