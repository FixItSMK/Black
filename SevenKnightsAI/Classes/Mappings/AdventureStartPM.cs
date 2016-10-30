using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureStartPM
    {
        #region Public Fields

        public static readonly int GOLD_OFFSET_X = 514;
        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly int KEY_OFFSET_X = 509;
        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping KeyPlusButton = new PixelMapping
        {
            X = 662,
            Y = 28,
            Color = 12690781,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AutoRepeatOn = new PixelMapping
        {
            X = 456,
            Y = 431,
            Color = 16706638,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AutoRepeatOff = new PixelMapping
        {
            X = 453,
            Y = 430,
            Color = 2824978,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle R_MapNumber = new Rectangle
        {
            X = 355,
            Y = 12,
            Width = 88,
            Height = 33
        };

        public static readonly PixelMapping UseFriendOn = new PixelMapping
        {
            X = 837,
            Y = 171,
            Color = 16630547,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UseFriendOff = new PixelMapping
        {
            X = 837,
            Y = 171,
            Color = 6113333,
            Type = MappingType.ANCHOR
        };

        #endregion Public Fields
    }
}