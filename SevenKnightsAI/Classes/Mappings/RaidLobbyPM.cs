using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidLobbyPM
    {
        public static readonly PixelMapping AttackedTab = new PixelMapping
        {
            X = 350,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DefeatedTab = new PixelMapping
        {
            X = 800,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DefeatedTabSelect = new PixelMapping
        {
            X = 800,
            Y = 70,
            Color = 14126341,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping EnterButton = new PixelMapping
        {
            X = 868,
            Y = 200,
            Color = 13873749,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GreenIconOnNewTab = new PixelMapping
        {
            X = 214,
            Y = 69,
            Color = 45085,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Border = new PixelMapping
        {
            X = 46,
            Y = 494,
            Color = 8877126,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Button = new PixelMapping
        {
            X = 120,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ManageParty2Border = new PixelMapping
        {
            X = 370,
            Y = 498,
            Color = 6773548,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty2Button = new PixelMapping
        {
            X = 323,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NewTab = new PixelMapping
        {
            X = 550,
            Y = 70,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedIconOnDefeatedTab = new PixelMapping
        {
            X = 718,
            Y = 57,
            Color = 13183490,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 809,
            Y = 134,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AwakenedRaidEnter = new PixelMapping
        {
            X = 804,
            Y = 448,
            Color = 8268811,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AwakenedRaidTab = new PixelMapping
        {
            X = 154,
            Y = 86,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AwakenedShard = new PixelMapping
        {
            X = 480,
            Y = 319,
            Color = 16643809,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle RaidLvl = new Rectangle
        {
            X = 191,
            Y = 175,
            Width = 70,
            Height = 25
        };

        public static readonly PixelMapping Raid50upLocation1 = new PixelMapping
        {
            X = 673,
            Y = 204,
            Color = 3549214,   // เลือดน้อยกว่า 50%
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Raid50upLocation2 = new PixelMapping
        {
            X = 673,
            Y = 278,
            Color = 3615263,  // เลือดน้อยกว่า 50%
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Raid50upLocation3 = new PixelMapping
        {
            X = 673,
            Y = 352,
            Color = 3417885,   // เลือดน้อยกว่า 50%
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Raid50upLocation4 = new PixelMapping
        {
            X = 673,
            Y = 426,
            Color = 3417885,  // เลือดน้อยกว่า 50%
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Raid50upLocation1Bt = new PixelMapping
        {
            X = 868,
            Y = 202,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Raid50upLocation2Bt = new PixelMapping
        {
            X = 868,
            Y = 276,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Raid50upLocation3Bt = new PixelMapping
        {
            X = 868,
            Y = 350,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Raid50upLocation4Bt = new PixelMapping
        {
            X = 868,
            Y = 424,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly int SCROLL_DELTA = 197;   // หาค่าตรงนี้้

        public static readonly PixelMapping ScrollAreaDown = new PixelMapping
        {
            X = 140,
            Y = 282,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ScrollAreaUp = new PixelMapping
        {
            X = 140,
            Y = 204,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}