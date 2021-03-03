using System;
using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.Utilities
{
    public static class ItemColorLerper
    {
        private static Color[] _myColors;
        private static int _colorIndex;
        private static float _lerpTime;
        private static Color _currentColor = _myColors[0];
        private static float _changeColorIndex;
        //public static Color TargetColor = Colors[1];
        //public static float Ratio = 0.01f;
        //public static int Index = 1;

        public static Color ColorLerper(Color[] colors, float lerpTime)
        {
            colors = _myColors;
            lerpTime = _lerpTime;

            _changeColorIndex = MathHelper.Lerp(_changeColorIndex, 1f, _lerpTime);
            if (_changeColorIndex > .9f)
            {
                _changeColorIndex = 0f;
                _colorIndex++;
                _colorIndex = _colorIndex >= _myColors.Length ? 0 : _colorIndex;
            }
            // else
            // {
            //     Ratio = 0.01f;
            //     CurrentColor = TargetColor;
            //     if (Index == 2)
            //     {
            //         Index = 0;
            //     }
            //     else
            //     {
            //         Index++;
            //     }
            //     TargetColor = Colors[Index];
            // }
            //
            return Color.Lerp(_currentColor, colors[_colorIndex], _lerpTime);
        }
    }
}