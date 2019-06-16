﻿namespace _1._4._26
{
    class Program
    {
        static void Main(string[] args)
        {
            // 证明点 A(a, a^3) B(b, b^3) C(c, c^3) 当且仅当 a + b + c = 0 时共线。
            //
            // 若点 A,B,C 共线，直线 AB 斜率必定和直线 BC 斜率相等，列方程有：
            // (b^3 - a^3)/(b - a) = (c^3 - b^3)/(c - b)
            // 用立方差公式化简，有：
            // b^2 + ab + a^2 = c^2 + bc + b^2
            // 消去 b^2，将 c 设为未知数有
            // c^2 +bc - a^2 - ab = 0
            // 用十字相乘法进行因式分解有
            // (a + b + c)(c - a) = 0
            // 解方程有：
            // c = -a - b 或 c = a
            // 因此当 c != a 时，当且仅当 a + b + c = 0 时 A, B, C 三点共线。
            // 得证。
        }
    }
}
