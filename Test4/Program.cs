using System;
using System.Collections.Generic;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> raindow = new Dictionary<string, string>();

            raindow["Red"] = "빨간색";
            raindow["Orange"] = "주황색";
            raindow["Yellow"] = "노랑색";
            raindow["Green"] = "초록색";
            raindow["Blue"] = "남색";
            raindow["Purple"] = "보라색";

            Console.WriteLine($"무지개 색은 {raindow["Red"]},{raindow["Orange"]},{raindow["Yellow"]},{raindow["Green"]},{raindow["Blue"]},{raindow["Purple"]} 입니다");
            Console.WriteLine();
            Console.WriteLine("Key와 Value확인");
            Console.WriteLine($"Purple은 {raindow["Purple"]} 입니다.");
        }
    }
}
