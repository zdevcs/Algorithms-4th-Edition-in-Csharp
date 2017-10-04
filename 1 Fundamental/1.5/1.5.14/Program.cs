﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionFind;

namespace _1._5._14
{
    /*
     * 1.5.14
     * 
     * 根据高度加权的 quick-union 算法。
     * 给出 UF 的一个实现，使用和加权 quick-union 算法相同的策略，
     * 但记录的是树的高度并总是将较矮的树连接到较高的树上。
     * 用算法证明 N 个触点的树的高度不会超过其大小的对数级别。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // 具体实现参见 WeightedQuickUnionByHeightUF.cs
            var UF = new WeightedQuickUnionByHeightUF(10);

            // 证明：
            // 一次 Union 操作只可能发生如下两种情况。
            // 1. 两棵树的高度相同，这样合并后的新树的高度等于较大那棵树的高度 +1。
            // 2. 两棵树的高度不同，这样合并后的新树高度等于较大那棵树的高度。
            //
            // 现在证明通过加权 quick-union 算法构造的高度为 h 的树至少包含 2^h 个结点。
            // 基础情况，高度 h=0, 结点数 k=1。
            // 为了使高度增加，必须用一棵高度相同的树合并，而 h=0 时结点数一定是 1，则：
            // h=1, k=2
            // 由于两棵大小不同的树合并，最大高度不会增加，只会增加结点数。
            // 因此，每次都使用相同高度的最小树进行合并，有：
            // h=2, k=4
            // h=3, k=8
            // h=4, k=16
            // ......
            // 递推即可得到结论，k >= 2^h
            // 因此 h <= lgk
        }
    }
}
