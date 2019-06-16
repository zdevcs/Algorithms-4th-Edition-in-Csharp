﻿using System;

namespace _1._4._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Deque<string> deque = new Deque<string>();

            deque.PushLeft("first");
            deque.PushRight("second");
            deque.PushRight("third");
            deque.PushRight("fourth");

            Console.WriteLine($"size:{deque.Size()}");
            while (!deque.IsEmpty())
            {
                Console.WriteLine(deque.PopLeft());
            }

            Console.WriteLine();

            deque.PushLeft("fourth");
            deque.PushRight("third");
            deque.PushRight("second");
            deque.PushRight("first");

            while (!deque.IsEmpty())
            {
                Console.WriteLine(deque.PopRight());
            }
        }
    }
}
