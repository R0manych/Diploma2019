using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance
{
    public static class FunctionUtils
    {
        public const int N = 2;

        public static List<Pair> GetPairs(int N)
        {
            var pairs = new List<Pair>();
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    pairs.Add(new Pair(ConvertToBool(i), ConvertToBool(j)));
                }
            }
            return pairs;
        }

        public static bool ConvertToBool(int x) => x == 1 ? true : false;

        public static Func<bool, bool, bool> CreateFunction() => Function;

        static bool Function(bool x, bool y) => x || y || (!x && !y);
    }

    public struct Pair
    {
        public bool X { get; set; }
        public bool Y { get; set; }

        public Pair(bool x, bool y)
        {
            X = x;
            Y = y;
        }
    }

    public enum FunctionType
    {
        None = 0,
        Balanced = 1,
        Constant = 2
    }
}
