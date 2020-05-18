using System;

namespace ddd.Repository
{
    class UserId
    {
        public readonly string value;

        public UserId(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            this.value = value;
        }

        public override string ToString()
        {
            return this.value;
        }
    }
}
