using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Comporators
{
    public class IntegerByAbsComorer : IComparer<int>
    {
        public int Compare(int x, int y) => Math.Abs(x).CompareTo(Math.Abs(y));
    }
}
