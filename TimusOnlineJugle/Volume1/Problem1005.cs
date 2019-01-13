using System;

namespace TimusOnlineJugle.Volume1
{
    class Problem1005
    {
        public static void ProMain(string[] args)
        {
            int iN, i, iW;
            string[] sAry_Ipts;
            int[] iAry_Ws;
            float fHalf;

            if (
                int.TryParse(Console.ReadLine(), out iN)
                && iN >= 1 && iN <= 20
            )
            {
                sAry_Ipts = Console.ReadLine().Split(' ');
                if (sAry_Ipts.Length == iN)
                {
                    iAry_Ws = new int[iN];
                    fHalf = 0;

                    for (i = 0; i < iN; ++i)
                    {
                        if (
                            int.TryParse(sAry_Ipts[i], out iW)
                            && iW >= 1 && iW <= 100000
                        )
                        {
                            iAry_Ws[i] = iW;
                            fHalf += iW;
                        }
                        else { break; }
                    }
                    if (i == iN)
                    {
                        Array.Sort(iAry_Ws);
                        fHalf /= 2;

                        Console.Write(MinDiffOfTwoPiles(iAry_Ws, iAry_Ws.Length - 1, fHalf, 0));
                    }
                }
            }

            // 暫停用
            Console.Read();
        }

        private static int MinDiffOfTwoPiles(int[] _iAry_Ws, int _iIdx, float _fHalf, int _iP1)
        {
            int iW, iP2, iMinDiff, iDiff;

            iW = _iAry_Ws[_iIdx];

            if (_iIdx == 0)
            {
                iP2 = ((int)(2 * _fHalf)) - _iP1 - iW;
                iMinDiff = (_iP1 < iP2 ? iP2 - _iP1 : _iP1 - iP2) - iW;
                if (iMinDiff < 0) { iMinDiff = -iMinDiff; }
            }
            else
            {
                if (_iP1 + iW <= _fHalf) { _iP1 += iW; }
                iMinDiff = int.MaxValue;

                for(int i = _iIdx - 1; i > -1; --i)
                {
                    iDiff = MinDiffOfTwoPiles(_iAry_Ws, i, _fHalf, _iP1);
                    if (iMinDiff > iDiff) { iMinDiff = iDiff; }
                    if (iMinDiff == 0) { break; }
                }
            }

            return iMinDiff;
        }
    }
}
