﻿namespace _1._4._36
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. N 个 Node<int> 对象的空间开销 = N * (16(对象开销) + 4(int) + 8(下一个 Node 的引用) + 4(填充字节)) = 32N
            // 2. 比起上一题来说，空间开销变为 = N * (16(Node 对象开销) + 8(Integer 对象引用) + (16(Integer 对象开销) + 4(int) + 4(填充字节)) + 8(下一个对象的引用) = 32N + 24N = 56N
            // 3. 如果不扩容则是 4N，N 个元素最多可以维持 4N 的栈空间（少于四分之一将缩小）。
            // 4. 比起上一题，数组元素变成了引用每个占用 8 字节，还要额外加上 Integer 对象的每个 24 字节。
            //    (8 + 24)N ~ (8 * 4 + 24)N
        }
    }
}
