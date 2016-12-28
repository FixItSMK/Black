using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class SpecialDungeonStartPM
    {
        public static readonly PixelMapping Cardlogo = new PixelMapping
        {
            X = 744,
            Y = 36,
            Color = 12036777,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Masterry = new PixelMapping
        {
            X = 378,
            Y = 173,
            Color = 12626265,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping KeyPlus = new PixelMapping
        {
            X = 703,
            Y = 26,
            Color = 14728309,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping CardPlus = new PixelMapping
        {
            X = 842,
            Y = 29,
            Color = 11573327,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SpecialBG = new PixelMapping
        {
            X = 243,
            Y = 67,
            Color = 13994756,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping StartButton = new PixelMapping
        {
            X = 664,
            Y = 494,
            Color = 5120782,
            Type = MappingType.BUTTON
        };
    }
}
