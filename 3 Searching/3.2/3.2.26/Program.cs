﻿using System;
using System.Collections.Generic;
using System.Linq;
using BinarySearchTree;

namespace _3._2._26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var n = 2; n <= 6; n++)
            {
                Console.WriteLine($"n={n}");
                var list = new List<int>();
                for (var i = 0; i < n; i++)
                {
                    list.Add(i);
                }

                var trees = new Dictionary<BST<int, int>, int>();
                var cases = GetPermutation(list);
                foreach (var test in cases)
                {
                    var tree = new BST<int, int>();
                    foreach (var num in test)
                    {
                        tree.Put(num, num);
                    }

                    // 是否存在相同结构的二叉树。
                    var pattern = trees.Select(d => d.Key).SingleOrDefault(t => BST<int, int>.IsStructureEqual(tree, t));

                    if (pattern == null)
                    {
                        trees.Add(tree, 1);
                    }
                    else
                    {
                        trees[pattern]++;
                    }
                }

                foreach (var pattern in trees)
                {
                    //Console.Write(pattern.Key);
                    Console.WriteLine(100 * pattern.Value / (float)cases.Count + "%");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 获得全排列。
        /// </summary>
        /// <param name="s">需要获取全排列的数列。</param>
        /// <returns>全排列。</returns>
        static List<int[]> GetPermutation(List<int> s)
        {
            var permutation = new List<int[]>();
            var temp = new List<int>();
            Permutation(s, temp, permutation);
            return permutation;
        }

        /// <summary>
        /// dfs 生成全排列。
        /// </summary>
        /// <param name="pool">剩余可选。</param>
        /// <param name="path">已选路径。</param>
        /// <param name="result">结果集。</param>
        static void Permutation(List<int> pool, List<int> path, List<int[]> result)
        {
            if (pool.Count == 0)
            {
                result.Add(path.ToArray());
                return;
            }

            for (var i = 0; i < pool.Count; i++)
            {
                var item = pool[i];
                path.Add(item);
                pool.RemoveAt(i);
                Permutation(pool, path, result);
                pool.Insert(i, item);
                path.Remove(item);
            }
        }
    }
}
