using System;

namespace CalamityRuTranslate.Common.Exceptions
{
    public class IDTypeException : Exception
    {
        private string _invalidId { get; }
        
        public IDTypeException(string invalidId)
        {
            _invalidId = invalidId;
        }
        
        public override string Message => $"ID \"{_invalidId}\" не найден!\n";
    }
}