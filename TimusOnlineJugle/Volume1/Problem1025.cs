using System;
using System.Collections.Generic;

namespace TimusOnlineJugle.Volume1
{
    class Problem1025
    {
        public static void ProMain(string[] args)
        {
            string sIpt;
            int iK,i,iPopulation;
            string[] sAry_Ipts;
            int[] iAry_GroupsPopulation;

            sIpt = Console.ReadLine();
            if (
                int.TryParse(sIpt, out iK)
                && iK % 2 == 1
                && iK >= 1 && iK <= 101
                )
            {
                sAry_Ipts = Console.ReadLine().Split(' ');
                if (sAry_Ipts.Length == iK)
                {
                    iAry_GroupsPopulation = new int[iK];
                    for (i = 0; i < iK; ++i)
                    {
                        if (
                            int.TryParse(sAry_Ipts[i], out iPopulation)
                            && iPopulation > 0 && iPopulation < 10000 && iPopulation % 2 == 1
                        )
                        {
                            iAry_GroupsPopulation[i] = iPopulation;
                        }
                        else { break; }
                    }
                    if (i == iK)
                    {
                        Array.Sort(iAry_GroupsPopulation);
                        iK = iK / 2 + 1;
                        iPopulation = 0;

                        for (i = 0; i < iK; i += 1)
                        {
                            iPopulation += iAry_GroupsPopulation[i] / 2 + 1;
                        }

                        Console.Write(iPopulation);
                    }
                }
            }

            // 暫停用
            Console.Read();
        }
    }
}
