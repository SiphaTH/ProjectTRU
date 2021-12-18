using System;

namespace CalamityRuTranslate.Common.Exceptions
{
    public class KeyTypeException : Exception
    {
        private string KeyText { get; }

        public KeyTypeException(string keyText)
        {
            KeyText = keyText;
        }

        public override string Message => $"Ключ перевода {KeyText} не найден";
    }
}