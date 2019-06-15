using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance
{
    public static class ClassicDeterminate
    {  
        public static FunctionType IsBalanced()
        {
            var func = FunctionUtils.CreateFunction();
            var data = FunctionUtils.GetPairs(FunctionUtils.N);

            var results = new List<bool>();

            for (var i = 0; i < Math.Pow(2, FunctionUtils.N - 1) + 1; i++)
            {
                results.Add(func(data[i].X, data[i].Y));
            }

            if (results.All(r => r == true) || results.All(r => r == false))
                return FunctionType.Constant;
            else return FunctionType.Balanced;
        }
    }    
}
