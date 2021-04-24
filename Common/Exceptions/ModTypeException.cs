using System;

namespace CalamityRuTranslate.Common.Exceptions
{
    public class ModTypeException : Exception
    {
        private string _invalidId { get; }
        
        public ModTypeException(string invalidId)
        {
            _invalidId = invalidId;
        }
        
        public override string Message => $"Ключ {_invalidId} не найден!\n";
    }
}