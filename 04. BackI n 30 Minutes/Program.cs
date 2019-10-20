using System;

namespace _04._BackI_n_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string hours = Console.ReadLine();
            string minutes = Console.ReadLine();

            int resultH = int.Parse(hours);
            int resutlM = int.Parse(minutes) + 30;

            if (resutlM >= 60)
            {
                resutlM = resutlM - 60;

                if (resultH == 23)
                {
                    resultH = 0;

                    Console.WriteLine($"{resultH.ToString("0")}:{ resutlM.ToString("00")}");
                }
                else
                {
                    resultH = resultH + 1;

                    if (resultH < 10)
                    {
                        Console.WriteLine("{0}:{1}", resultH.ToString("0"), resutlM.ToString("00"));
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", resultH.ToString("00"), resutlM.ToString("00"));
                    }
                }

            }
            else
            {
                if (resultH < 10)
                {
                    Console.WriteLine("{0}:{1}", resultH.ToString("0"), resutlM.ToString("00"));
                }
                else
                {
                    Console.WriteLine("{0}:{1}", resultH.ToString("00"), resutlM.ToString("00"));
                }


            }
        }
    }
}
