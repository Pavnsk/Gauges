﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using МашиностроительнаяБиблиотека;

namespace МашиностроительнаяБиблиотекаТесты
{
    [TestFixture]
    class КалькуляторПробокТесты
    {
        РазмерCОтклонениями[] размерыОтверстий = {
            new РазмерCОтклонениями(5.6m, 0m, 0.12m), 
            new РазмерCОтклонениями(300m, 0.110m, 0.320m), 
            new РазмерCОтклонениями(8.72m, 0m, 0.036m),
            new РазмерCОтклонениями(4.63m, 0m, 0.025m)
        };

        РазмерCОтклонениями[] ОжидРазмерыПробокПР = { 
            new РазмерCОтклонениями(5.6145m, -0.005m, 0m),
            new РазмерCОтклонениями(300.143m, -0.012m, 0m),
            new РазмерCОтклонениями(8.7285m, -0.0025m, 0m),
            new РазмерCОтклонениями(4.6375m, -0.0025m, 0m)
        };

        decimal[] ОжидРазмерыПробокПРизнош = { 5.6m, 300.119m, 8.72m, 4.63m };

        РазмерCОтклонениями[] ОжидРазмерыПробокНЕ = {
            new РазмерCОтклонениями(5.7225m, -0.005m, 0m),
            new РазмерCОтклонениями(300.317m, -0.012m, 0m),
            new РазмерCОтклонениями(8.7570m, -0.0025m, 0m),
            new РазмерCОтклонениями(4.656m, -0.0025m, 0m)
        };

        [Test]
        public void ВычислитьРазмерПробкиПР()
        {
            for (int i = 0; i < размерыОтверстий.Length; i++)
            {
                РазмерCОтклонениями РазмерПробкиПР = КалькуляторПробок.ВычислитьРазмерПробкиПР(размерыОтверстий[i]);
                Assert.AreEqual(ОжидРазмерыПробокПР[i], РазмерПробкиПР);
            }
        }

        [Test]
        public void ВычислитьРазмерПробкиПРизнош()
        {
            for (int i = 0; i < размерыОтверстий.Length; i++)
            {
                decimal РазмерПробкиПРизнош = КалькуляторПробок.ВычислитьРазмерПробкиПРизнош(размерыОтверстий[i]);
                Assert.AreEqual(ОжидРазмерыПробокПРизнош[i], РазмерПробкиПРизнош);
            }
        }

        [Test]
        public void ВычислитьРазмерПробкиНЕ()
        {
            for (int i = 0; i < размерыОтверстий.Length; i++)
            {
                РазмерCОтклонениями РазмерПробкиНЕ = КалькуляторПробок.ВычислитьРазмерПробкиНЕ(размерыОтверстий[i]);
                Assert.AreEqual(ОжидРазмерыПробокНЕ[i], РазмерПробкиНЕ);
            }
        }

        decimal[] размерыДляОкругления = { 0.1m, 0.001m, 100m, 1.0005m, 1.00025m, 1.00075m };
        decimal[] ожидРазмерыОкрВМеньшуюСторону = { 0.1m, 0.001m, 100m, 1.0005m, 1.0000m, 1.0005m };
        decimal[] ожидРазмерыОкрВБольшуюСторону = { 0.1m, 0.001m, 100m, 1.0005m, 1.0005m, 1.001m };

        [Test]
        public void ОкруглитьРазмерДоПоловиныМикрометраВМеньшуюСторону()
        {
            for (int i = 0; i < размерыДляОкругления.Length; i++)
            {
                decimal окрРазмер = КалькуляторПробок.ОкруглитьРазмерДоПоловиныМикрометраВМеньшуюСторону(размерыДляОкругления[i]);
                Assert.AreEqual(ожидРазмерыОкрВМеньшуюСторону[i], окрРазмер);
            }
        }

        [Test]
        public void ОкруглитьРазмерДоПоловиныМикрометраВБольшуюСторону()
        {
            for (int i = 0; i < размерыДляОкругления.Length; i++)
            {
                decimal окрРазмер = КалькуляторПробок.ОкруглитьРазмерДоПоловиныМикрометраВБольшуюСторону(размерыДляОкругления[i]);
                Assert.AreEqual(ожидРазмерыОкрВБольшуюСторону[i], окрРазмер);
            }
        }
    }
}
