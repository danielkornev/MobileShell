﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZU.Apps.Austin3
{
    public static class Constants
    {
        public static class Colors
        {
            public static string Violet = "#FF93207D";
            public static string Orange = "#FFD4B21C";
            public static string LightGreen = "#FF8CAC1D";
            public static string LightBlue = "#FF1C8FC6";
            public static string KingBrown = "#FF862526";
            public static string DarkGray = "#FF414141";
            public static string BeautifulGreen = "#FF1DA07E";
            public static string MidGray = "#FF646464";
        }

        public enum Side
        {
            Left,
            Right,
            Unknown
        }

        public static class KnownEntities
        {
            /// <summary>
            /// Used for the First Journal.
            /// </summary>
            public static Guid FirstJournal = Guid.Parse("0E4A20E5-5572-4C69-A2F0-9FE25276F1C5");
        }
    } // class
} // namespace
