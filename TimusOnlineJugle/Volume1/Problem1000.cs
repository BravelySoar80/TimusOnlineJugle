using System;

namespace TimusOnlineJugle.Volume1
{
    class Problem1000
    {
        public static void ProMain(string[] args)
        {
            string[] sAry_Ipts;
            int iIptA, iIptB;

            sAry_Ipts = Console.ReadLine().Split(' ');
            if (
                sAry_Ipts.Length > 1
                && int.TryParse(sAry_Ipts[0], out iIptA)
                && int.TryParse(sAry_Ipts[1], out iIptB)
            )
            {
                Console.WriteLine(iIptA + iIptB);
            }

            // 暫停用
            Console.Read();
        }
    }
}
