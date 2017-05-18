using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace МашиностроительнаяБиблиотекаТесты
{
    static class Program
    {     
        [STAThread]
        static void Main()
        {
           NUnit.Gui.AppEntry.Main(new string[] { "МашиностроительнаяБиблиотекаТесты.exe" } );
        }
    }
}
