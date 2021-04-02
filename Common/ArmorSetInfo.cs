namespace CalamityRuTranslate.Common
{
    public readonly struct ArmorSetInfo
    {
        private readonly int _headType;
        private readonly int _bodyType;
        private readonly int _legsType;
        private readonly string _armorSetName;

        public ArmorSetInfo(int headType, int bodyType, int legsType, string armorSetName)
        {
            _headType = headType;
            _bodyType = bodyType;
            _legsType = legsType;
            _armorSetName = armorSetName;
        }

        public bool CheckArmorSet(int headType, int bodyType, int legsType) => _headType == headType && _bodyType == bodyType && _legsType == legsType;

        public string GetArmorSetName() => _armorSetName;
    }
}