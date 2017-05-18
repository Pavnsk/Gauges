using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace МашиностроительнаяБиблиотека
{
    public class ПолеДопуска
    {
        ОсновноеОтклонение основноеОтклонение;
        int квалитет;
        decimal[] интервалыРазмеров;
        decimal[] верхнииОтклонения;
        decimal[] нижнииОтклонения;

        internal ПолеДопуска(ОсновноеОтклонение основноеОтклонение, int квалитет, decimal[] интервалыРазмеров, decimal[] верхнииОтклонения, decimal[] нижнииОтклонения)
        {
            this.основноеОтклонение = основноеОтклонение;
            this.квалитет = квалитет;
            this.интервалыРазмеров = интервалыРазмеров;
            this.верхнииОтклонения = верхнииОтклонения;
            this.нижнииОтклонения = нижнииОтклонения;
        }

        public ОсновноеОтклонение ОсновноеОтклонение
        {
            get { return основноеОтклонение; }
        }

        public int Квалитет
        {
            get { return квалитет; }
        }

        public override string ToString()
        {
            return основноеОтклонение.ToString() + квалитет.ToString();
        }

        internal decimal НайтиВерхнееОтклонение(decimal размер)
        {
            int i = Array.FindIndex<decimal>(интервалыРазмеров, граница => (граница >= размер));
            return верхнииОтклонения[i]/1000;
        }

        internal decimal НайтиНижнееОтклонение(decimal размер)
        {
            int i = Array.FindIndex<decimal>(интервалыРазмеров, граница => (граница >= размер));
            return нижнииОтклонения[i] / 1000;
        }

        internal decimal НайтиДопуск(decimal размер)
        {
            return Math.Abs(НайтиВерхнееОтклонение(размер) - НайтиНижнееОтклонение(размер));
        }
    }
}
