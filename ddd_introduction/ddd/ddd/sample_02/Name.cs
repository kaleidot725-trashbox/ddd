using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ddd.sample_02
{
    class Name
    {
        private readonly string value;

        public Name(string value) 
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (!ValidateName(value)) throw new ArgumentException(nameof(value));
            this.value = value;
        }

        private bool ValidateName(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z]+$");
        }

        public override string ToString()
        {
            return value;
        }
    }
}
