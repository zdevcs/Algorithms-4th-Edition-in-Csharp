﻿namespace _1._4._35
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 一个 Node 对象包含一个 int(泛型 Item) 的引用和下一个 Node 对象的引用。push 操作创建 Node 对象时会创建一个引用。
            // 因此对于第一种情况，压入 n 个 int 类型的元素创建了 N 个 Node 对象，创建了 2N 个引用。
            // 2. 比起上一种情况，每个 Node 对象多包含了一个指向 Integer 的引用。
            // 因此对于第二中情况，压入 n 个 int 类型的元素创建了 N 个 Node 对象和 N 个 Integer 对象，比起第一种情况多创建了 N 个引用。
            // 3. 对于数组来说，创建对象只有扩容时重新创建数组对象一种情况，对于 N 次 push 操作只需要 lgN 次扩容，因此创建的对象为 lgN 个。
            // 每次扩容都需要重新创建引用，(4 + 8 +...+ 2N)(扩容) + N(每次 push 操作) = 5N - 4 = ~5N
            // 4. 创建引用和上题一样，创建对象则多出了装箱过程，每次 push 都会新建一个 Integer 对象，N + lgN = ~N。
        }
    }
}
