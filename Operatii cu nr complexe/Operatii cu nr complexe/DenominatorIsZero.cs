using System;
using System.Runtime.Serialization;

namespace Operatii_cu_nr_complexe
{
    [Serializable]
    internal class DenominatorIsZero : Exception
    {
        private int real;

        public DenominatorIsZero()
        {
        }

        public DenominatorIsZero(int real)
        {
            this.real = real;
        }

        public DenominatorIsZero(string message) : base(message)
        {
        }

        public DenominatorIsZero(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DenominatorIsZero(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}