using System;
using System.Collections;

namespace TimusOnlineJugle.Volume1
{
    class Problem1001
    {
        public static void ProMain(string[] args)
        {
            string sIpt, sLongNum;
            string[] sAry_ipts;
            long lNum;
            Stack stkIpts;

            stkIpts = new Stack();
            while (true)
            {
                sIpt = Console.ReadLine();
                if (sIpt == null)
                {
                    break;
                }
                else
                {
                    sAry_ipts = sIpt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < sAry_ipts.Length; ++i)
                    {
                        sLongNum = sAry_ipts[i];
                        if (long.TryParse(sLongNum, out lNum))
                        {
                            stkIpts.Push(lNum);
                        }
                    }
                }
            }

            try
            {
                while (stkIpts.Peek() != null)
                {
                    lNum = Convert.ToInt64(stkIpts.Pop());
                    Console.WriteLine("{0:0.0000}", Math.Sqrt(lNum));
                }
            }
            catch
            {

            }

            // 暫停用
            Console.Read();
        }
    }
}
