using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorization
{
    public static class Shenks
    {
        static double P0, Q0, r0, P1, Q1, r1;
        const double SMALL_B = 0.04;

        public static double Solve(int N)
        {
            if (IsFullSquare(N))
                return Math.Sqrt(N);
            if (N % 4 == 1)
                N /= 2;
            SetFirstData(N, SMALL_B);
            double Pk, Qk, rk;
            do
            {
                Pk = r1 * Q1 - P1;
                Qk = Q0 + (P1 - Pk) * r1;
                rk = Math.Truncate(Pk + Math.Truncate(Math.Sqrt(SMALL_B * N)) / Qk);

                P0 = P1;
                P1 = Pk;
                Q0 = Q1;
                Q1 = Qk;
                r0 = r1;
                r1 = rk;
            }
            while (!IsFullSquare(Qk));
            SetSecondData(N, SMALL_B, Pk, Qk, rk);
            double Pj, Qj, rj;
            do
            {
                Pj = r1 * Q1 - P1;
                Qj = Q0 + (P1 - Pj) * r1;
                rj = Math.Truncate(Pj + Math.Truncate(Math.Sqrt(SMALL_B * N)) / Qj);

                P0 = P1;
                P1 = Pj;
                Q0 = Q1;
                Q1 = Qj;
                r0 = r1;
                r1 = rj;
            }
            while (Pj != P0);
            return Qj;
        }

        private static bool IsFullSquare(double N) => Math.Pow(Math.Sqrt(N), 2) == Math.Pow(Math.Truncate(Math.Sqrt(N)), 2);

        private static void SetFirstData(int N, double b)
        {
            P0 = 0;
            Q0 = 1;
            r0 = Math.Truncate(Math.Sqrt(b * N));
            P1 = Math.Truncate(Math.Sqrt(b * N));
            Q1 = b * N - r0 * r0;
            r1 = Math.Truncate(2 * r0 / Q1);
        }

        private static void SetSecondData(int N, double b, double Pk, double Qk, double rk)
        {
            P0 = -Pk;
            Q0 = Math.Sqrt(Qk);
            r0 = Math.Truncate(P0 + Math.Truncate(Math.Sqrt(b * N)) / Q0);
            P1 = r0 * Q0 - P0;
            Q1 = (b * N - P1 * P1) / Q0;
            r1 = Math.Truncate(P1 + Math.Truncate(Math.Sqrt(b * N)) / Q1);
        }
    }
}
