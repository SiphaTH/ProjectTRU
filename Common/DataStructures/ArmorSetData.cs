namespace CalamityRuTranslate.Common.DataStructures
{
    public readonly struct ArmorSetData
    {
        public int HeadType { get; }
        public int BodyType { get; }
        public int LegsType { get; }
        public string ArmorSetName { get; }

        public ArmorSetData(int headType, int bodyType, int legsType, string armorSetName)
        {
            HeadType = headType;
            BodyType = bodyType;
            LegsType = legsType;
            ArmorSetName = armorSetName;
        }

        public bool CheckArmorSet(int headType, int bodyType, int legsType) => HeadType == headType && BodyType == bodyType && LegsType == legsType;

        public bool CheckHeadOfArmorSet(int headType, out string armorSetName)
        {
            armorSetName = ArmorSetName;

            return HeadType == headType;
        }

        public override string ToString() => ArmorSetName;
    }
}