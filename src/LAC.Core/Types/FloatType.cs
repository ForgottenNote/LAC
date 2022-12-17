using System.Runtime.CompilerServices;
using LAC.Core.Interfaces;

namespace LAC.Core.Types
{
    public class FloatType : IType<float>
    {
        public static readonly FloatType Instance = new();

        #region Constructors

        private FloatType()
        {
        }

        #endregion

        #region Implementation of IType<ulong>

        public float Get(byte[] buffer)
        {
            return Unsafe.ReadUnaligned<ulong>(ref buffer[0]);
        }

        public void Set(byte[] buffer, float value)
        {
            Unsafe.As<byte, float>(ref buffer[0]) = value;
        }

        public int Size()
        {
            return sizeof(ulong);
        }

        #endregion
    }
}