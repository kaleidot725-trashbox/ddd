using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.Entity
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
