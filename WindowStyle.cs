using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowResearcher
{
    /**
     * Класс, определяющий стиль окна
     **/
    class WindowStyle
    {
        public string name; //Название стиля
        public UInt32   id; //Идентификатор стиля

        public WindowStyle()
        {
            name = "";
            id = 0;
        }
    }
}
