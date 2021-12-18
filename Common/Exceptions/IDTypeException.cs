using System;

namespace CalamityRuTranslate.Common.Exceptions
{
    public class IdTypeException : Exception
    {
        private string InvalidId { get; }

        public IdTypeException(string invalidId)
        {
            InvalidId = invalidId;
        }

        public override string Message => $"ID \"{InvalidId}\" не найден!\n";
    }
}