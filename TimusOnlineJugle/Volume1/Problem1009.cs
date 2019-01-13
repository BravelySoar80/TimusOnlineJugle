using System;
using System.Collections.Generic;

namespace TimusOnlineJugle.Volume1
{
    class Problem1009
    {
        public static void ProMain(string[] args)
        {
            int iN, iK, iZeroCount, iOthersCount, iValidCount;
            iK = 0;
            if (
                int.TryParse(Console.ReadLine(), out iN)
                && iN >= 2
                && int.TryParse(Console.ReadLine(), out iK)
                && iK >= 2 && iK <= 10 && iN + iK <= 18
            )
            {
                iZeroCount = iValidCount = 0;
                iOthersCount = iN - 1;

                while (iZeroCount <= iOthersCount + 1)
                {
                    iValidCount +=
                        ((int)Math.Pow(iK - 1, iOthersCount))
                        * Combination(iOthersCount + 1, iZeroCount);

                    ++iZeroCount;
                    --iOthersCount;
                }

                Console.Write((iK - 1) * iValidCount);
            }

            // 暫停用
            Console.Read();
        }

        private static int Combination(int _iN, int _iK)
        {
            int iCombination;

            if (_iK > _iN - _iK) { _iK = _iN - _iK; }

            if (_iK == 0) { iCombination = 1; }
            else
            {
                iCombination = 1;
                for(int i = 1; i <= _iK; ++i)
                {
                    iCombination = iCombination * (_iN - i + 1) / i;
                }
            }

            return iCombination;
        }
    }
}
