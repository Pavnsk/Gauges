using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace МашиностроительнаяБиблиотека
{
    public class РазмерCОтклонениями
    {
        decimal номинальныйРазмер = 0;
        decimal нижнееОтклонение = 0;
        decimal верхнееОтклонение = 0;

        public РазмерCОтклонениями(decimal номинальныйРазмер, decimal нижнееОтклонение, decimal верхнееОтклонение)
        {
            if (нижнееОтклонение > верхнееОтклонение)
            {
                throw new ArgumentException("нижнееОтклонение > верхнееОтклонение");
            }
            this.номинальныйРазмер = номинальныйРазмер;
            this.нижнееОтклонение = нижнееОтклонение;
            this.верхнееОтклонение = верхнееОтклонение;
        }

        public decimal НоминальныйРазмер { get { return номинальныйРазмер; } }
        public decimal НижнееОтклонение { get { return нижнееОтклонение; } }
        public decimal ВерхнееОтклонение { get { return верхнееОтклонение; } }

        public decimal Допуск()
        {
            return Math.Abs(верхнееОтклонение - нижнееОтклонение);
        }

        public decimal НаименьшийПредельныйРазмер()
        {
            return номинальныйРазмер + нижнееОтклонение;
        }

        public decimal НаибольшийПредельныйРазмер()
        {
            return номинальныйРазмер + верхнееОтклонение;
        }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(obj, null)) return false;
            if (Object.ReferenceEquals(this, obj)) return true;

            РазмерCОтклонениями размер = (РазмерCОтклонениями)obj;
            if (номинальныйРазмер != размер.номинальныйРазмер) return false;
            if (нижнееОтклонение != размер.нижнееОтклонение) return false;
            if (верхнееОтклонение != размер.верхнееОтклонение) return false;
            return true;
        }
        
        public override int GetHashCode()
        {
            return номинальныйРазмер.GetHashCode() ^ нижнееОтклонение.GetHashCode() ^ верхнееОтклонение.GetHashCode(); 
        }

        public override string ToString()
        {
            return String.Format("[{0}; {1}; {2}]", номинальныйРазмер, нижнееОтклонение, верхнееОтклонение);
        }
    }

}
