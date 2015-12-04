using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowResearcher
{
    /**
     * Статический класс, предоставляющий методы для отслеживания 
     * текущих координат курсора и получения дескриптора окна, 
     * находящегося в этих координатах
     **/
    static class WindowSearcher
    {
        private static Point _cursorPosition; //Текущие координаты курсора

        /**
         * Получить координаты курсора
         **/ 
        public static Point getCursorPosition()
        {
            WinApiFunctions.GetCursorPos(ref _cursorPosition);
            return _cursorPosition;
        }

        /**
         * Получить дескриптор окна 
         * находящегося в указанных координатах
        **/
        public static IntPtr getWindowHandle()
        {
            IntPtr handle = WinApiFunctions.WindowFromPoint(_cursorPosition);
            return handle;
        }
    }
}
