using System;
namespace ddd.ApplicationService
{
    public class MailAddress
    {
        public readonly string Value;

        public MailAddress(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            this.Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
