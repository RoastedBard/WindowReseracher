using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WindowResearcher
{
    /**
     * Структура, определяющая прямоугольник ограничивающий окно
     **/
    [StructLayout(LayoutKind.Sequential)]
    struct Rect
    {
        public int Left;        // Х координата верхнего левого угла
        public int Top;         // Y координата верхнего левого угла
        public int Right;       // X координата нижнего правого угла
        public int Bottom;      // Y координата нижнего правого угла
    }
}
