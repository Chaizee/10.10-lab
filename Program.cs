﻿class Lab
{

    public static void Main(string[] args)
    {
        int next = 1;

        while (next > 0)
        {
            int neew,result=0;
            next = int.Parse(Console.ReadLine());
            neew = next;
            while (neew > 0)
            {
                if ((neew % 10) % 2 == 0)
                {
                    neew = neew / 10;
                }
                else
                {
                    result = result * 10 + neew % 10;
                    neew = neew / 10;
                }
            }
            if (result == 0)
            {
                Console.WriteLine("все цифры четные");
            }
            else
            {
                Console.WriteLine(result);
            }
            



        }
    }
}
