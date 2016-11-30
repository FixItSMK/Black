using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidReadyPM
    {
        #region Public Fields

        public static readonly Rectangle EnteredCount = new Rectangle
        {
            X = 729,
            Y = 297,
            Height = 24,
            Width = 53
        };

        public static readonly PixelMapping MemberListBackground = new PixelMapping
        {
            X = 40,
            Y = 69,
            Color = 1708300,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 740,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBorderLeft = new PixelMapping
        {
            X = 555,
            Y = 475,
            Color = 16376483,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButtonBorderRight = new PixelMapping
        {
            X = 924,
            Y = 475,
            Color = 16376483,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AwakenBlueIcon = new PixelMapping
        {
            //X = 591,
            //Y = 15,
            //Color = 703981,
            X = 601,
            Y = 27,
            Color = 4227735,
            Type = MappingType.ANCHOR
        };



        // Awaken หน้ากดเริ่มตีเข้าสู Flight
        public static readonly PixelMapping AwakenDragonImg = new PixelMapping
        {
            X = 589,
            Y = 128,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AwakenedReadyButton = new PixelMapping
        {
            X = 775,
            Y = 497,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}