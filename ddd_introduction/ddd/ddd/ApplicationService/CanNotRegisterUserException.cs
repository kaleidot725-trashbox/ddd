using System;
using System.Runtime.Serialization;

namespace ddd.ApplicationService
{
    [Serializable]
    internal class CanNotRegisterUserException : Exception
    {
        private string userId;
        private string v;

        public CanNotRegisterUserException()
        {
        }

        public CanNotRegisterUserException(string message) : base(message)
        {
        }

        public CanNotRegisterUserException(string userId, string v)
        {
            this.userId = userId;
            this.v = v;
        }

        public CanNotRegisterUserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CanNotRegisterUserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}