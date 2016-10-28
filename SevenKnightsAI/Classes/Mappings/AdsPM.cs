using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdsPM
    {
        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 945,
            Y = 525,
            Color = 16436480,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping CloseAds = new PixelMapping
        {
            X = 946,
            Y = 523,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SkipTodayCheckBox_1 = new PixelMapping
        {
            X = 17,
            Y = 518,
            Color = 5592405,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SkipTodayCheckBox_2 = new PixelMapping
        {
            X = 17,
            Y = 532,
            Color = 5592405,
            Type = MappingType.BOTH
        };
    }
}