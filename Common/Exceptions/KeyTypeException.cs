using System;

namespace CalamityRuTranslate.Common.Exceptions
{
    public class KeyTypeException : Exception
    {
        private string _keyText { get; }

        public KeyTypeException(string keyText)
        {
            _keyText = keyText;
        }

        public override string Message => $"Ключ перевода {_keyText} не найден";
    }
}