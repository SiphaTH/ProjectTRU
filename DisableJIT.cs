using System.Reflection;
using Terraria.ModLoader;

namespace CalamityRuTranslate;

public class DisableJIT : PreJITFilter
{
    public override bool ShouldJIT(MemberInfo member) => false;
}