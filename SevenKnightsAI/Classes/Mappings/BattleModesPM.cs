using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class BattleModesPM
    {
        #region Public Fields

        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 180,
            Y = 180,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BorderBottomRight = new PixelMapping
        {
            X = 842,
            Y = 310,
            Color = 16644567,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderBottomRightIndonesian = new PixelMapping
        {
            X = 884,
            Y = 199,
            Color = 2758922,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderTopLeft = new PixelMapping
        {
            X = 190,
            Y = 282,
            Color = 2825740,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderTopLeftIndonesian = new PixelMapping
        {
            X = 139,
            Y = 118,
            Color = 3616324,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BossFightButton = new PixelMapping
        {
            X = 720,
            Y = 425,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CastleRushButton = new PixelMapping
        {
            X = 800,
            Y = 190,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 218;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GoldPlusButton = new PixelMapping
        {
            X = 550,
            Y = 29,
            Color = 11573327,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GuildWarButton = new PixelMapping
        {
            X = 260,
            Y = 400,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 227;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly int RUBY_OFFSET_X = 223;

        public static readonly int RUBY_OFFSET_Y = 0;

        #endregion Public Fields
    }
}