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
            Color = 12986369,
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
        // จุดตรวจสอบจากบนลงล่าง ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // ตรวจชื่อ   (เช็คเสร็จแล้ว)
        public static readonly Rectangle RaidNameUpToDownL0 = new Rectangle
        {
            X = 295,
            Y = 204,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameUpToDownL1 = new Rectangle
        {
            X = 295,
            Y = 278,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameUpToDownL2 = new Rectangle
        {
            X = 295,
            Y = 353,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameUpToDownL3 = new Rectangle
        {
            X = 295,
            Y = 428,
            Width = 215,
            Height = 26
        };

        // ปุ่มหัวมังกร (เช็คเสร็จแล้ว)
        public static readonly PixelMapping RaidUpToDownBtn0 = new PixelMapping
        {
            X = 868,
            Y = 202,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn1 = new PixelMapping
        {
            X = 868,
            Y = 276,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn2 = new PixelMapping
        {
            X = 868,
            Y = 350,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn3 = new PixelMapping
        {
            X = 868,
            Y = 424,
            Color = 13939542,
            Type = MappingType.BOTH
        };


        // เช็คล่างสุดว่าถึงรึยัง (ตรวจเสร็จแล้ว)
        public static readonly PixelMapping FixedUpCheck = new PixelMapping
        {
            X = 906,
            Y = 167,
            Color = 5983284,
            Type = MappingType.ANCHOR
        };

        /*หน้าที่ 2*/
        // ตำแหน่งเช็คชื่อ             -------------------------- ยังไม่มีค่า
        public static readonly Rectangle RaidNameUpToDownL0P2 = new Rectangle
        {
            X = 295,
            Y = 204,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameUpToDownL1P2 = new Rectangle
        {
            X = 295,
            Y = 278,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameUpToDownL2P2 = new Rectangle
        {
            X = 295,
            Y = 353,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameUpToDownL3P2 = new Rectangle
        {
            X = 295,
            Y = 428,
            Width = 215,
            Height = 26
        };

        // ปุ่มหัวมังกร         (ตรวจเสร็จแล้ว)
        public static readonly PixelMapping RaidUpToDownBtn0P2 = new PixelMapping
        {
            X = 868,
            Y = 202,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn1P2 = new PixelMapping
        {
            X = 868,
            Y = 276,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn2P2 = new PixelMapping
        {
            X = 868,
            Y = 350,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn3P2 = new PixelMapping
        {
            X = 868,
            Y = 424,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping FixedUpCheckP2 = new PixelMapping
        {
            X = 906,
            Y = 167,
            Color = 9665623,
            Type = MappingType.ANCHOR
        };


        // เลื่อนจากล่างขึ้นบน**********************************************************************************************
        // จุดที่ใช้ตรวจสอบชื่อ (ตรวจเสร็จแล้ว)
        public static readonly Rectangle RaidNameDownToUpL0 = new Rectangle
        {
            X = 295,
            Y = 208,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameDownToUpL1 = new Rectangle
        {
            X = 295,
            Y = 281,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameDownToUpL2 = new Rectangle
        {
            X = 295,
            Y = 356,
            Width = 145,
            Height = 26
        };

        public static readonly Rectangle RaidNameDownToUpL3 = new Rectangle
        {
            X = 295,
            Y = 428,
            Width = 215,
            Height = 26
        };

        // จุดที่ใช้ตรวจสอบปุ่ม(หัวมังกร)
        // (ตรวจเสร็จแล้ว)
        public static readonly PixelMapping RaidDownToUpBtn0 = new PixelMapping
        {
            X = 868,
            Y = 202,
            Color = 13807956,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidDownToUpBtn1 = new PixelMapping
        {
            X = 868,
            Y = 276,
            Color = 13807956,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidDownToUpBtn2 = new PixelMapping
        {
            X = 868,
            Y = 350,
            Color = 13807956,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidDownToUpBtn3 = new PixelMapping
        {
            X = 868,
            Y = 424,
            Color = 13807956,
            Type = MappingType.BOTH
        };

        // เช็คล่างสุดว่าถึงรึยัง
        public static readonly PixelMapping FixedDownCheck = new PixelMapping
        {
            X = 906,
            Y = 170,
            Color = 10586722,
            Type = MappingType.ANCHOR
        };

        //--------------------------------------- จุดสำหรับ Scoll หน้าจอ-----------------
        public static readonly PixelMapping ScrollAreaDown = new PixelMapping
        {
            X = 450,
            Y = 430,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ScrollAreaUp = new PixelMapping
        {
            X = 450,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        //------------------------------------ จุดที่ใช้ตรวจสอบ เลือด (ตรวจเสร็จแล้ว)-----------------
        public static readonly PixelMapping Raid50UpToDownL0 = new PixelMapping
        {
            X = 673,
            Y = 204,
            Color = 3549214,   // เลือดน้อยกว่า 50%
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Raid50UpToDownL1 = new PixelMapping
        {
            X = 673,
            Y = 278,
            Color = 3615263,  // เลือดน้อยกว่า 50%
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Raid50UpToDownL2 = new PixelMapping
        {
            X = 673,
            Y = 352,
            Color = 3417885,   // เลือดน้อยกว่า 50%
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Raid50UpToDownL3 = new PixelMapping
        {
            X = 673,
            Y = 426,
            Color = 3417885,  // เลือดน้อยกว่า 50%
            Type = MappingType.ANCHOR
        };

    }
}