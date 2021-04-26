using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kioskigospDALL.Models
{
    public class Kiosk
    {

        public int KioskId { get; set; }
        public string Nomer { get; set; }
        public string ModelKioska { get; set; }
        public Nullable<DateTime> Arenda { get; set; }
        public Towns Town { get; set; }
        public string Adress { get; set; }
        public double Area { get; set; }

    }


    public enum Towns
    {
        Гомель, Ветка, БудаКошелева, Добруш, Речица, Хойники, Жлобин, Рогачев, Корма, Брагин, Лоев, Чечерск, Светлогорск, Октябрьский, Мозырь, Калинковичи, Петриков, Житковичи, Туров, Наровля, Ельск, Лельчицы
    }

}
