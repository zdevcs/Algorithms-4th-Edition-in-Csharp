﻿using System;
using System.Collections.Generic;
using BinarySearchTree;

namespace _3._2._25
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new[]
            {
                new KeyValuePair<int, int>(6, 6),
                new KeyValuePair<int, int>(4, 4),
                new KeyValuePair<int, int>(8, 8),
                new KeyValuePair<int, int>(3, 3),
                new KeyValuePair<int, int>(1, 1),
                new KeyValuePair<int, int>(7, 7)
            };
            var bst = new BSTBalanced<int, int>(data);
            Console.WriteLine(bst);
        }
    }
}
