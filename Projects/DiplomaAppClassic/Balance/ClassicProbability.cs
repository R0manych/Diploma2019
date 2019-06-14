using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance
{
    public class ClassicProbability
    {
        public static int k;

        public static FunctionType IsBalanced()
        {
            var func = FunctionUtils.CreateFunction();
            var data = FunctionUtils.GetPairs(FunctionUtils.N);

            var results = new List<bool>();

            var rand = new Random();
            k = rand.Next((int)Math.Pow(2, FunctionUtils.N - 1)) + 1;

            for (var i = 0; i < k; i++)
            {
                results.Add(func(data[i].X, data[i].Y));
            }

            if (results.All(r => r == true) || results.All(r => r == false))
                return FunctionType.Constant;
            else return FunctionType.Balanced;
        }
    }
}
