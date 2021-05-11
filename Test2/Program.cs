using System;

namespace Test2
{
    class Boiler
    {
        private byte voltage;
        private int temperature;
        public string Brand;
        public byte Voltage
        {
            get { return this.voltage; }
            set
            {
                //110V과 220V만 저장할수 있도록 처리
                if (value < 110)
                {
                    this.voltage = 110;
                }
                else if (value > 220)
                {
                    this.voltage = 220;
                }
                else
                {
                    this.voltage = value;
                }
            }
        }
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                // 물온도는5도 이하면 5도로, 70도 이상이면 70도로 제한
                if (value < 5)
                {
                    this.temperature = 5;
                }
                else if (value > 70)
                {
                    this.temperature = 70;
                }
                else
                {
                    this.temperature = value;
                }
                
            }
        }
        public void PrintAll()
        {
            Console.WriteLine($"Brand = {Brand}, Voltage = {Voltage}, Temperature = {Temperature}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 0, Temperature = 1000 };
            kitturami.PrintAll();
        }
    }
}
