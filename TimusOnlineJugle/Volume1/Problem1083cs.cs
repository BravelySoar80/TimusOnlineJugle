using System;

namespace TimusOnlineJugle.Volume1
{
    class Problem1083cs
    {
        public static void ProMain(string[] args)
        {
            string[] sAry_Ipts;
            int iN, iK, i,iResult;
            string sExclamations;

            sAry_Ipts = Console.ReadLine().Split(' ');
            if (
                sAry_Ipts.Length == 2
                && int.TryParse(sAry_Ipts[0], out iN)
                && iN >= 1 && iN <= 10
            )
            {
                sExclamations = sAry_Ipts[1];
                iK = sExclamations.Length;
                if (iK >= 1 && iK <= 20)
                {
                    for (i = 0; i < iK; ++i)
                    {
                        if (sExclamations[i] != '!') { break; }
                    }
                    if (i == iK)
                    {
                        i = iN % iK;
                        if (i == 0) { i = iK; }
                        iResult = 1;

                        while (i <= iN)
                        {
                            iResult *= i;
                            i += iK;
                        }

                        Console.Write(iResult);
                    }
                }
            }


            // 暫停用
            Console.Read();
        }
    }
}
