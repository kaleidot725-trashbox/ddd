using System;

namespace ddd.Factory
{
    class UserId
    {
        public readonly string Value;

        public UserId(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
