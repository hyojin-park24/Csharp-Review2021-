﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A049_PrimeNumber
    {
        /*소수 판단하기*/
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요 : ");
            int num = int.Parse(Console.ReadLine());
            int index;

            for (index = 2; index < num; index++)
            {
                if (num % index == 0)
                {
                    Console.WriteLine("{0}은 소수가 아닙니다.", num);
                    break;
                }
            }

            if (index == num)
                Console.WriteLine("{0}은 소수입니다.", num);
        }
    }
}
