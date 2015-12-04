using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowResearcher
{
    /**
     * Класс, заключающий в себе константы WinAPI 
     **/
    static class NativeConstants
    {
        public const int GWL_STYLE = (-16);
        public const int GWL_ID = (-12);
        public const int GWL_EXSTYLE = (-20);

        public static WindowStyle[] windowStyles = new WindowStyle[49];

        static NativeConstants()
        {
            initializeWindowStyles();
        }

        private static void initializeWindowStyles()
        {
            for (int i = 0; i < windowStyles.Length; i++)
                windowStyles[i] = new WindowStyle();

            windowStyles[0].name = "WS_OVERLAPPED"; windowStyles[0].id = 0;
            windowStyles[1].name = "WS_POPUP"; windowStyles[1].id = 0x80000000;
            windowStyles[2].name = "WS_CHILD"; windowStyles[2].id = 0x40000000;
            windowStyles[3].name = "WS_MINIMIZE"; windowStyles[3].id = 0x20000000;
            windowStyles[4].name = "WS_VISIBLE"; windowStyles[4].id = 0x10000000;
            windowStyles[5].name = "WS_DISABLED"; windowStyles[5].id = 0x8000000;
            windowStyles[6].name = "WS_CLIPSIBLINGS"; windowStyles[6].id = 0x4000000;
            windowStyles[7].name = "WS_CLIPCHILDREN"; windowStyles[7].id = 0x2000000;
            windowStyles[8].name = "WS_MAXIMIZE"; windowStyles[8].id = 0x1000000;
            windowStyles[9].name = "WS_CAPTION"; windowStyles[9].id = 0xC00000;      // WS_BORDER or WS_DLGFRAME  
            windowStyles[10].name = "WS_BORDER"; windowStyles[10].id = 0x800000;
            windowStyles[11].name = "WS_DLGFRAME"; windowStyles[11].id = 0x400000;
            windowStyles[12].name = "WS_VSCROLL"; windowStyles[12].id = 0x200000;
            windowStyles[13].name = "WS_HSCROLL"; windowStyles[13].id = 0x100000;
            windowStyles[14].name = "WS_SYSMENU"; windowStyles[14].id = 0x80000;
            windowStyles[15].name = "WS_THICKFRAME"; windowStyles[15].id = 0x40000;
            windowStyles[16].name = "WS_GROUP"; windowStyles[16].id = 0x20000;
            windowStyles[17].name = "WS_TABSTOP"; windowStyles[17].id = 0x10000;
            windowStyles[18].name = "WS_MINIMIZEBOX"; windowStyles[18].id = 0x20000;
            windowStyles[19].name = "WS_MAXIMIZEBOX"; windowStyles[19].id = 0x10000;
            windowStyles[20].name = "WS_TILED"; windowStyles[20].id = 0;
            windowStyles[21].name = "WS_ICONIC"; windowStyles[21].id = 0x20000000;
            windowStyles[22].name = "WS_SIZEBOX"; windowStyles[22].id = 0x40000;

            //Window Styles       
            windowStyles[23].name = "WS_EX_DLGMODALFRAME"; windowStyles[23].id = 0x0001;
            windowStyles[24].name = "WS_EX_NOPARENTNOTIFY"; windowStyles[24].id = 0x0004;
            windowStyles[25].name = "WS_EX_TOPMOST"; windowStyles[25].id = 0x0008;
            windowStyles[26].name = "WS_EX_ACCEPTFILES"; windowStyles[26].id = 0x0010;
            windowStyles[27].name = "WS_EX_TRANSPARENT"; windowStyles[27].id = 0x0020;
            windowStyles[28].name = "WS_EX_MDICHILD"; windowStyles[28].id = 0x0040;
            windowStyles[29].name = "WS_EX_TOOLWINDOW"; windowStyles[29].id = 0x0080;
            windowStyles[30].name = "WS_EX_WINDOWEDGE"; windowStyles[30].id = 0x0100;
            windowStyles[31].name = "WS_EX_CLIENTEDGE"; windowStyles[31].id = 0x0200;
            windowStyles[32].name = "WS_EX_CONTEXTHELP"; windowStyles[32].id = 0x0400;
            windowStyles[33].name = "WS_EX_RIGHT"; windowStyles[33].id = 0x1000;
            windowStyles[34].name = "WS_EX_LEFT"; windowStyles[34].id = 0x0000;
            windowStyles[35].name = "WS_EX_RTLREADING"; windowStyles[35].id = 0x2000;
            windowStyles[36].name = "WS_EX_LTRREADING"; windowStyles[36].id = 0x0000;
            windowStyles[37].name = "WS_EX_LEFTSCROLLBAR"; windowStyles[37].id = 0x4000;
            windowStyles[38].name = "WS_EX_RIGHTSCROLLBAR"; windowStyles[38].id = 0x0000;
            windowStyles[39].name = "WS_EX_CONTROLPARENT"; windowStyles[39].id = 0x10000;
            windowStyles[40].name = "WS_EX_STATICEDGE"; windowStyles[40].id = 0x20000;
            windowStyles[41].name = "WS_EX_APPWINDOW"; windowStyles[41].id = 0x40000;
            windowStyles[42].name = "WS_EX_OVERLAPPEDWINDOW"; windowStyles[42].id = (windowStyles[31].id | windowStyles[32].id);
            windowStyles[43].name = "WS_EX_PALETTEWINDOW"; windowStyles[43].id = (windowStyles[31].id | windowStyles[30].id | windowStyles[26].id);
            windowStyles[44].name = "WS_EX_LAYERED"; windowStyles[44].id = 0x00080000;
            windowStyles[45].name = "WS_EX_NOINHERITLAYOUT"; windowStyles[45].id = 0x00100000; // Disable inheritence of mirroring by children
            windowStyles[46].name = "WS_EX_LAYOUTRTL"; windowStyles[46].id = 0x00400000; // Right to left mirroring
            windowStyles[47].name = "WS_EX_COMPOSITED"; windowStyles[47].id = 0x02000000;
            windowStyles[48].name = "WS_EX_NOACTIVATE"; windowStyles[48].id = 0x08000000;
        }

    }
}
