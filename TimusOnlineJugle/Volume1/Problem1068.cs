using System;

namespace TimusOnlineJugle.Volume1
{
    class Problem1068
    {
        public static void ProMain(string[] args)
        {
            string sIpt;
            int iN;

            sIpt = Console.ReadLine();
            if (
                int.TryParse(sIpt, out iN)
                && iN >= -10000 && iN <= 10000
            )
            {
                Console.WriteLine(
                    (1 + iN)
                    * ((1 < iN ? iN - 1 : 1 - iN) + 1)
                    / 2
                );
            }

            // 暫停用
            Console.Read();
        }
    }
}
