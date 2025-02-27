﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A051_InfiniteLoop
    {
        /*무한루프와 break문*/
        static void Main(string[] args)
        {
            /*첫날 1000원저금 후 매일 전날의 두배씩 저금하여 100만원만들기*/
            int sum = 0;
            int days = 1;
            int money = 1000;

            while (true)    //무한반복
            {
                sum += money;

                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);
                if (sum >= 1000000)
                    break;
                days++;
                money *= 2;
            }
            Console.WriteLine("{0}일치에 {1:###,###}원이 됩니다.", days, sum);

            for (sum = 0, days=1, money= 1000; ; days++, money *= 2)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);
                if (sum >= 1000000)
                {
                    break;
                }
            }
            Console.WriteLine("{0}일치에 {1:###,###}원이 됩니다.", days, sum);
        }
    }
}
