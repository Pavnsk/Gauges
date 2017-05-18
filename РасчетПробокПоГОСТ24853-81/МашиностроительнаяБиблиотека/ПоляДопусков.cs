using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace МашиностроительнаяБиблиотека
{
    public enum ОсновноеОтклонение { A, B, C, CD, E, F, FG, G, H, JS, K, M, N, P, R, S, T, U, V, X, Y, Z, ZA, ZB, ZC,
                                     a, b, c, cd, e, f, fg, g, h, js, k, m, n, p, r, s, t, u, v, x, y, z, za, zb, zc};

    public static class ПоляДопусков
    {     

        public static ПолеДопуска H4 = new ПолеДопуска(ОсновноеОтклонение.H, 4,
             new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { 3m, 4m,  4m,  5m,  6m,  7m,  8m,  10m,  12m,  14m,  16m,  18m,  20m },
             new decimal[] {  0,  0,   0,   0,   0,   0,   0,    0,    0,    0,    0,    0,    0 }
        );        

        public static ПолеДопуска H5 = new ПолеДопуска(ОсновноеОтклонение.H, 5,
             new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { 4m, 5m,  6m,  8m,  9m, 11m, 13m,  15m,  18m,  20m,  23m,  25m,  27m },
             new decimal[] {  0,  0,   0,   0,   0,   0,   0,    0,    0,    0,    0,    0,    0 }
        );
 
        public static ПолеДопуска H6 = new ПолеДопуска(ОсновноеОтклонение.H, 6,
             new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { 6m, 8m,  9m, 11m, 13m, 16m, 19m,  22m,  25m,  29m,  32m,  36m,  40m },
             new decimal[] {  0,  0,   0,   0,   0,   0,   0,    0,    0,    0,    0,    0,    0 }
        ); 
        
        public static ПолеДопуска H7 = new ПолеДопуска(ОсновноеОтклонение.H, 7,
             new decimal[] {  3m,  6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { 10m, 12m, 15m, 18m, 21m, 25m, 30m,  35m,  40m,  46m,  52m,  57m,  63m },
             new decimal[] {   0,   0,   0,   0,   0,   0,   0,    0,    0,    0,    0,    0,    0 }
        );

        public static ПолеДопуска H8 = new ПолеДопуска(ОсновноеОтклонение.H, 8,
             new decimal[] {  3m,  6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { 14m, 18m, 22m, 27m, 33m, 39m, 46m,  54m,  63m,  72m,  81m,  89m,  97m },
             new decimal[] {   0,   0,   0,   0,   0,   0,   0,    0,    0,    0,    0,    0,    0 }
        ); 

        public static ПолеДопуска H9 = new ПолеДопуска(ОсновноеОтклонение.H, 9,
             new decimal[] {  3m,  6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { 25m, 30m, 36m, 43m, 52m, 62m, 74m,  87m, 100m, 115m, 130m, 140m, 155m },
             new decimal[] {   0,   0,   0,   0,    0,  0,   0,    0,    0,    0,    0,    0,    0 }
        );

        public static ПолеДопуска H10 = new ПолеДопуска(ОсновноеОтклонение.H, 10,
             new decimal[] {  3m,  6m, 10m, 18m, 30m,  50m,  80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { 40m, 48m, 58m, 70m, 84m, 100m, 120m, 140m, 160m, 185m, 210m, 230m, 250m },
             new decimal[] {   0,   0,   0,   0,   0,    0,    0,    0,    0,    0,    0,    0,    0 }
        );

        public static ПолеДопуска H11 = new ПолеДопуска(ОсновноеОтклонение.H, 11,
             new decimal[] {  3m,  6m, 10m,  18m,  30m,  50m,  80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { 60m, 75m, 90m, 110m, 130m, 160m, 190m, 220m, 250m, 290m, 320m, 360m, 400m },
             new decimal[] {   0,   0,   0,    0,    0,    0,    0,    0,    0,    0,    0,    0,    0 }
        );

        public static ПолеДопуска H12 = new ПолеДопуска(ОсновноеОтклонение.H, 12,
             new decimal[] {  3m,   6m,  10m,  18m,  30m,  50m,  80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] {100m, 120m, 150m, 180m, 210m, 250m, 300m, 350m, 400m, 460m, 520m, 570m, 630m },
             new decimal[] {   0,    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,    0,    0 }
        );
//-------------------------
        public static ПолеДопуска g4 = new ПолеДопуска(ОсновноеОтклонение.g, 4,
             new decimal[] {  3m,  6m, 10m,  18m,  30m,  50m,  80m, 120m, 180m, 250m, 315m, 400m, 500m },
             new decimal[] { -2m, -4m, -5m,  -6m,  -7m,  -9m, -10m, -12m, -14m, -15m, -17m, -18m, -20m },
             new decimal[] { -5m, -8m, -9m, -11m, -13m, -16m, -18m, -22m, -26m, -29m, -33m, -36m, -40m }
        ); 

        public static ПолеДопуска h4 = new ПолеДопуска(ОсновноеОтклонение.h, 4,
             new decimal[] {  3m,  6m,  10m,  18m,  30m,  50m,  80m,  120m,  180m,  250m,  315m,  400m,  500m },
             new decimal[] {   0,   0,    0,    0,    0,    0,    0,     0,     0,     0,     0,     0,     0 },
             new decimal[] { -3m, -4m,  -4m,  -5m,  -6m,  -7m,  -8m,  -10m,  -12m,  -14m,  -16m,  -18m,  -20m }
        );

        public static ПолеДопуска js4 = new ПолеДопуска(ОсновноеОтклонение.js, 4,
            new decimal[] {    3m,  6m, 10m,   18m, 30m,   50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] {  1.5m,  2m,  2m,  2.5m,  3m,  3.5m,  4m,   5m,   6m,   7m,   8m,   9m,  10m },
            new decimal[] { -1.5m, -2m, -2m, -2.5m, -3m, -3.5m, -4m,  -5m,  -6m,  -7m,  -8m,  -9m, -10m }
        );

        public static ПолеДопуска k4 = new ПолеДопуска(ОсновноеОтклонение.k, 4,
            new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { 3m, 5m,  5m,  6m,  8m,  9m, 10m,  13m,  15m,  18m,  20m,  22m,  25m },
            new decimal[] { 0m, 1m,  1m,  1m,  2m,  2m,  2m,   3m,   3m,   4m,   4m,   4m,   5m }
        );

        public static ПолеДопуска m4 = new ПолеДопуска(ОсновноеОтклонение.m, 4,
            new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { 5m, 8m, 10m, 12m, 14m, 16m, 19m,  23m,  27m,  31m,  36m,  39m,  43m },
            new decimal[] { 2m, 4m,  6m,  7m,  8m,  9m, 11m,  13m,  15m,  17m,  20m,  21m,  23m }
        );

        public static ПолеДопуска g5 = new ПолеДопуска(ОсновноеОтклонение.g, 5,
            new decimal[] {  3m,  6m,  10m,  18m,  30m,  50m,  80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { -2m, -4m,  -5m,  -6m,  -7m,  -9m, -10m, -12m, -14m, -15m, -17m, -18m, -20m },
            new decimal[] { -6m, -9m, -11m, -14m, -16m, -20m, -23m, -27m, -32m, -35m, -40m, -43m, -47m }
        );

        public static ПолеДопуска h5 = new ПолеДопуска(ОсновноеОтклонение.h, 5,
             new decimal[] {  3m,  6m,  10m,  18m,  30m,  50m,  80m,  120m,  180m,  250m,  315m,  400m,  500m },
             new decimal[] {   0,   0,    0,    0,    0,    0,    0,     0,     0,     0,     0,     0,     0 },
             new decimal[] { -4m, -5m,  -6m,  -8m,  -9m, -11m, -13m,  -15m,  -18m,  -20m,  -23m,  -25m,  -27m }
        );

        public static ПолеДопуска js5 = new ПолеДопуска(ОсновноеОтклонение.js, 5,
            new decimal[] {    3m,    6m,   10m,   18m,   30m,   50m,   80m,  120m,  180m,   250m,   315m,    400m,   500m },
            new decimal[] {  2.0m,  2.5m,  3.0m,  4.0m,  4.5m,  5.5m,  6.5m,  7.5m,  9.0m,  10.0m,  11.5m,   12.5m,  13.5m },
            new decimal[] { -2.0m, -2.5m, -3.0m, -4.0m, -4.5m, -5.5m, -6.5m, -7.5m, -9.0m, -10.0m, -11.5m,  -12.5m, -13.5m }
        );

        // j5

        public static ПолеДопуска k5 = new ПолеДопуска(ОсновноеОтклонение.k, 5,
            new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { 4m, 6m,  7m,  9m, 11m, 13m, 15m,  18m,  21m,  24m,  27m,  29m,  32m },
            new decimal[] { 0m, 1m,  1m,  1m,  2m,  2m,  2m,   3m,   3m,   4m,   4m,   4m,   5m }
        );
//-------------------
        public static ПолеДопуска m5 = new ПолеДопуска(ОсновноеОтклонение.m, 5,
            new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { 6m, 9m, 12m, 15m, 17m, 20m, 24m,  28m,  33m,  37m,  43m,  46m,  50m },
            new decimal[] { 2m, 4m,  6m,  7m,  8m,  9m, 11m,  13m,  15m,  17m,  20m,  21m,  23m }
        );

        public static ПолеДопуска n5 = new ПолеДопуска(ОсновноеОтклонение.n, 5,
            new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { 8m,13m, 16m, 20m, 24m, 28m, 33m,  38m,  45m,  51m,  57m,  62m,  67m },
            new decimal[] { 4m, 8m, 10m, 12m, 15m, 17m, 20m,  23m,  27m,  31m,  34m,  37m,  40m }
        );

        public static ПолеДопуска f6 = new ПолеДопуска(ОсновноеОтклонение.f, 6,
             new decimal[] {   3m,   6m,  10m,  18m,  30m,  50m,  80m, 120m, 180m, 250m, 315m, 400m,  500m },
             new decimal[] {  -6m, -10m, -13m, -16m, -20m, -25m, -30m, -36m, -43m, -50m, -56m, -62m,  -68m },
             new decimal[] { -12m, -18m, -22m, -27m, -33m, -41m, -49m, -58m, -68m, -79m, -88m, -98m, -108m }
        ); 

        public static ПолеДопуска g6 = new ПолеДопуска(ОсновноеОтклонение.g, 6,
            new decimal[] {  3m,   6m,  10m,  18m,  30m,  50m,  80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { -2m,  -4m,  -5m,  -6m,  -7m,  -9m, -10m, -12m, -14m, -15m, -17m, -18m, -20m },
            new decimal[] { -8m, -12m, -14m, -17m, -20m, -25m, -29m, -34m, -39m, -44m, -49m, -54m, -60m }
        );

        public static ПолеДопуска h6 = new ПолеДопуска(ОсновноеОтклонение.h, 6,
             new decimal[] {  3m,  6m,  10m,  18m,  30m,  50m,  80m,  120m,  180m,  250m,  315m,  400m,  500m },
             new decimal[] {   0,   0,    0,    0,    0,    0,    0,     0,     0,     0,     0,     0,     0 },
             new decimal[] { -6m, -8m,  -9m, -11m, -13m, -16m, -19m,  -22m,  -25m,  -29m,  -32m,  -36m,  -40m }
        );

        public static ПолеДопуска js6 = new ПолеДопуска(ОсновноеОтклонение.js, 6,
            new decimal[] {    3m,    6m,   10m,   18m,   30m,   50m,   80m,   120m,   180m,   250m,   315m,    400m,   500m },
            new decimal[] {  3.0m,  4.0m,  4.5m,  5.5m,  6.5m,  8.0m,  9.5m,  11.0m,  12.5m,  14.5m,  16.0m,   18.0m,  20.0m },
            new decimal[] { -3.0m, -4.0m, -4.5m, -5.5m, -6.5m, -8.0m, -9.5m, -11.0m, -12.5m, -14.5m, -16.0m,  -18.0m, -20.0m }
        );

        public static ПолеДопуска k6 = new ПолеДопуска(ОсновноеОтклонение.k, 6,
            new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { 6m, 9m, 10m, 12m, 15m, 18m, 21m,  25m,  28m,  33m,  36m,  40m,  45m },
            new decimal[] { 0m, 1m,  1m,  1m,  2m,  2m,  2m,   3m,   3m,   4m,   4m,   4m,   5m }
        );

        public static ПолеДопуска m6 = new ПолеДопуска(ОсновноеОтклонение.m, 6,
            new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { 8m,12m, 15m, 18m, 21m, 25m, 30m,  35m,  40m,  46m,  52m,  57m,  63m },
            new decimal[] { 2m, 4m,  6m,  7m,  8m,  9m, 11m,  13m,  15m,  17m,  20m,  21m,  23m }
        );

        public static ПолеДопуска n6 = new ПолеДопуска(ОсновноеОтклонение.n, 6,
            new decimal[] {  3m,  6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] { 10m, 16m, 19m, 23m, 28m, 33m, 39m,  45m,  52m,  60m,  66m,  73m,  80m },
            new decimal[] {  4m,  8m, 10m, 12m, 15m, 17m, 20m,  23m,  27m,  31m,  34m,  37m,  40m }
        );

        public static ПолеДопуска e7 = new ПолеДопуска(ОсновноеОтклонение.e, 7,
             new decimal[] {   3m,   6m,  10m,  18m,  30m,  50m,  80m,  120m,  180m,  250m,  315m,  400m,  500m },
             new decimal[] { -14m, -20m, -25m, -32m, -40m, -50m, -60m,  -72m,  -85m, -100m, -110m, -125m, -135m },
             new decimal[] { -24m, -32m, -40m, -50m, -61m, -75m, -90m, -107m, -125m, -146m, -162m, -182m, -198m }
        ); 

        public static ПолеДопуска f7 = new ПолеДопуска(ОсновноеОтклонение.f, 7,
             new decimal[] {   3m,   6m,  10m,  18m,  30m,  50m,  80m, 120m, 180m, 250m,  315m,  400m,  500m },
             new decimal[] {  -6m, -10m, -13m, -16m, -20m, -25m, -30m, -36m, -43m, -50m,  -56m,  -62m,  -68m },
             new decimal[] { -16m, -22m, -28m, -34m, -41m, -50m, -60m, -71m, -83m, -96m, -108m, -119m, -131m }
        ); 

        public static ПолеДопуска h7 = new ПолеДопуска(ОсновноеОтклонение.h, 7,
             new decimal[] {   3m,   6m,  10m,  18m,  30m,  50m,  80m,  120m,  180m,  250m,  315m,  400m,  500m },
             new decimal[] {    0,    0,    0,    0,    0,    0,    0,     0,     0,     0,     0,     0,     0 },
             new decimal[] { -10m, -12m, -15m, -18m, -21m, -25m, -30m,  -35m,  -40m,  -46m,  -52m,  -57m,  -63m }
        );

        public static ПолеДопуска js7 = new ПолеДопуска(ОсновноеОтклонение.js, 7,
            new decimal[] {    3m,    6m,   10m,   18m,    30m,    50m,    80m,   120m,   180m,   250m,   315m,    400m,   500m },
            new decimal[] {  5.0m,  6.0m,  7.0m,  9.0m,  10.0m,  12.0m,  15.0m,  17.0m,  20.0m,  23.0m,  26.0m,   28.0m,  31.0m },
            new decimal[] { -5.0m, -6.0m, -7.0m, -9.0m, -10.0m, -12.0m, -15.0m, -17.0m, -20.0m, -23.0m, -26.0m,  -28.0m, -31.0m }
        );

       public static ПолеДопуска k7 = new ПолеДопуска(ОсновноеОтклонение.k, 7,
            new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
            new decimal[] {10m,13m, 16m, 19m, 23m, 27m, 32m,  38m,  43m,  50m,  56m,  61m,  68m },
            new decimal[] { 0m, 1m,  1m,  1m,  2m,  2m,  2m,   3m,   3m,   4m,   4m,   4m,   5m }
        );


        public static ПолеДопуска[] Все = { H4, H5, H6, H7, H8, H9, H10, H11, H12,
                                            g4, h4, js4, k4, m4, g5, h5, js5, k5,
                                            m5, n5, f6, g6, h6, js6, k6, m6, n6,
                                            e7, f7, h7, js7, k7
                                          };
    }
}
