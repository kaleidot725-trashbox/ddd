using System;
using System.Text.RegularExpressions;

namespace ddd.Factory
{
    public class Name
    {
        public readonly string Value;

        public Name(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (!ValidateName(value)) throw new ArgumentException(nameof(value));
            this.Value = value;
        }

        private bool ValidateName(string str)
        {
            if (str.Length < 3) return false;
            if (str.Length > 20) return false;
            if (!Regex.IsMatch(str, @"^[a-zA-Z0-9]+$")) return false;
            return true;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
