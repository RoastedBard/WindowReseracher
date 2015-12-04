using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowResearcher
{
    public partial class WindowResearcherMainForm : Form
    {

        private Cursor         _searchCursor; //Курсор в виде прицела появляющийся во время поиска окна
        private FoundWindow    _foundWindow;  //Найденное окно

        public WindowResearcherMainForm()
        {
            InitializeComponent();
            _searchCursor = WinApiFunctions.LoadCustomCursor("SearchCursor.cur"); //Загрузить изображение курсора
        }

        /**
         * Изменить изображение курсора и picturebox'а с прицелом
        **/
        private void changeCursorAndPictureBoxImage(Cursor cursor, Image image)
        {
            this.Cursor = cursor;
            pictureBoxSearch.Image = image;
        }

        /**
         * Процедура заполнения полей с данными на форме
         **/
        private void fillInformationControls()
        {
            labelXMousePosition.Text = "X: " + WindowSearcher.getCursorPosition().X.ToString();
            labelYMousePosition.Text = "Y: " + WindowSearcher.getCursorPosition().Y.ToString();

            textBoxWindowHandle.Text = WindowSearcher.getWindowHandle().ToString();
            textBoxWindowClass.Text = _foundWindow.getWindowClass();
            textBoxWindowCaption.Text = _foundWindow.getWindowCaption();
            textBoxWindowStyles.Text = _foundWindow.getWindowStyles();
            textBoxWindowWidth.Text = _foundWindow.getWindowSize().X.ToString();
            textBoxWindowHeight.Text = _foundWindow.getWindowSize().Y.ToString();
            textBoxWindowPositionX.Text = _foundWindow.getWindowPosition().X.ToString();
            textBoxWindowPositionY.Text = _foundWindow.getWindowPosition().Y.ToString();
        }

        /**
         * Процедура выполняющаяся каждый такт таймера:
         *-Если ни одного окна ещё не было найдено, то
         * инициализировать переменную foundWindow
         *-Иначе переинициализировать поля переменной foundWindow
         * в соответствии с полученным дескриптором 
         * и заполнить поля с данными на форме 
        **/
        private void runWindowSearching()
        {
            if (_foundWindow == null)
                _foundWindow = new FoundWindow(WindowSearcher.getWindowHandle());

            else
            {
                _foundWindow.initializeWindow(WindowSearcher.getWindowHandle());
                fillInformationControls();
            }
        }

        private void timerSearch_Tick(object sender, EventArgs e)
        {
            runWindowSearching();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            changeCursorAndPictureBoxImage(_searchCursor, null);
            timerSearch.Start();
        }

        private void pictureBoxSearch_MouseUp(object sender, MouseEventArgs e)
        {
            changeCursorAndPictureBoxImage(Cursors.Default, Properties.Resources.SearchStop);
            timerSearch.Stop();
            labelXMousePosition.Text = "X:";
            labelYMousePosition.Text = "Y:";
        }
    }
}
