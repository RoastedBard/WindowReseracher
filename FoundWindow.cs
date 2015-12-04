using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowResearcher
{
    /**
     * Класс, определяющий окно, найденное по координатам курсора 
     **/
    class FoundWindow
    {
        private StringBuilder _windowClassName;         //Имя класса окна
        private StringBuilder _windowCaption;           //Заголовок окна
        private Rectangle     _windowRectangle;         //Прямоугольник, ограничивающий окно(с#)
        private Rect          _nativeWindowRectangle;   //Прямоугольник, ограничивающий окно(native)
        private Point         _windowPosition;          //Координаты окна
        private Point         _windowSize;              //Размеры окна
        private IntPtr        _windowHandle;            //Дескриптор окна
        private IntPtr        _hdc;                     //Дескриптор контекста устройства

        /**
         * Конструктор
         * @param hwnd дескриптор окна найденного по координатам курсора
        **/
        public FoundWindow(IntPtr hwnd)
        {
            initializeWindow(hwnd);   
        }

        /**
         * Переинициализировать поля класса в соответствии с полученным дескриптором
         * @param hwnd дескриптор окна найденного по координатам курсора
        **/
        public void initializeWindow(IntPtr hwnd)
        {
            _windowHandle = hwnd;

            _hdc = WinApiFunctions.GetWindowDC(_windowHandle);

            _windowClassName = new StringBuilder(100);
            _windowCaption = new StringBuilder(100);

            WinApiFunctions.GetClassName(hwnd, _windowClassName, _windowClassName.Capacity);

            WinApiFunctions.GetWindowText(hwnd, _windowCaption, _windowCaption.Capacity);

            _calculateWindowRectangle();

            _calculateWindowPosition();

            _calculateWindowSize();
        }

        /**
        * Получить стили окна 
        **/
        public string getWindowStyles()
        {
            long windowStyle = WinApiFunctions.GetWindowLong(_windowHandle, NativeConstants.GWL_EXSTYLE);

            for (int i = 0; i < NativeConstants.windowStyles.Length; i++)
            {
                if (windowStyle == NativeConstants.windowStyles[i].id)
                    return NativeConstants.windowStyles[i].name + " ";
            }

            return null;
        }

        /**
         * Получить координаты окна
        **/
        public Point getWindowPosition()
        {
            return _windowPosition;
        }

        /**
         * Получить размер окна
        **/
        public Point getWindowSize()
        {
            return _windowSize;
        }

        /**
         * Получить имя класса окна
        **/
        public string getWindowClass()
        {
            return _windowClassName.ToString();
        }

        /**
         * Получить заголовок окна
        **/
        public string getWindowCaption()
        {
            return _windowCaption.ToString();
        }

        /**
         * Получить дескриптор окна
        **/
        public IntPtr getWindowHandle()
        {
            return _windowHandle;
        }

        /**
         * Вычислить прямоугольник ограничивающий окно
        **/
        private void _calculateWindowRectangle()
        {
            WinApiFunctions.GetWindowRect(_windowHandle, out _nativeWindowRectangle);

            _windowRectangle.X      = _nativeWindowRectangle.Left;
            _windowRectangle.Y      = _nativeWindowRectangle.Top;
            _windowRectangle.Width  = _nativeWindowRectangle.Right  - _nativeWindowRectangle.Left;
            _windowRectangle.Height = _nativeWindowRectangle.Bottom - _nativeWindowRectangle.Top;
        }

        /**
         * Вычислить размер окна
        **/
        private void _calculateWindowSize()
        {
            _windowSize.X = _windowRectangle.Width;
            _windowSize.Y = _windowRectangle.Height;
        }

        /**
         * Вычислить координаты окна
        **/
        private void _calculateWindowPosition()
        {
            _windowPosition.X = _windowRectangle.Left;
            _windowPosition.Y = _windowRectangle.Top;
        }
    }
}
