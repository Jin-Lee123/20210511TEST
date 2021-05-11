using System;

namespace Test5
{
    interface IAnimal
    {
        void Name(string name);
        void Age(int age);
        void Eat(string eat);    
        void Sleep(string sleep);
        void Sound(string sound);
    }
    class Dog : IAnimal
    {
        public void Age(int age)
        {
            Console.WriteLine($"강아지가 나이는{age}입니다.");
        }

        public void Eat(string eat)
        {
            Console.WriteLine($"강아지가 {eat}를 먹습니다.");
        }

        public void Name(string name)
        {
            Console.WriteLine($"강아지 이름은 {name}입니다.");
        }

        public void Sleep(string sleep)
        {
            Console.WriteLine($"{sleep}을 잡니다.");
        }

        public void Sound(string sound)
        {
            Console.WriteLine($"강아지가 {sound}소리를 냅니다.");
        }
    }
    class Cat : IAnimal
    {
        public void Age(int age)
        {
            Console.WriteLine($"고양이 나이는 {age} 입니다.");
        }

        public void Eat(string eat)
        {
            Console.WriteLine($"고양이가 {eat}를 먹습니다.");
        }

        public void Name(string name)
        {
            Console.WriteLine($"고양이 이름은 {name} 입니다.");
        }

        public void Sleep(string sleep)
        {
            Console.WriteLine($"{sleep}을 잡니다.");
        }

        public void Sound(string sound)
        {
            Console.WriteLine($"고양이가 {sound}소리를 냅니다.");
        }
    }
    class Hores : IAnimal
    {
        public void Age(int age)
        {
            Console.WriteLine($"말의 나이는 {age} 입니다.");
        }

        public void Eat(string eat)
        {
            Console.WriteLine($"말이 {eat}를 먹습니다.");
        }

        public void Name(string name)
        {
            Console.WriteLine($"말의 이름은 {name} 입니다.");
        }

        public void Sleep(string sleep)
        {
            Console.WriteLine($"{sleep}을 잡니다.");
        }

        public void Sound(string sound)
        {
            Console.WriteLine($"말이 {sound}소리를 냅니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal bakgoo = new Dog();
            bakgoo.Name("백구");
            bakgoo.Age(10);
            bakgoo.Eat("사료");
            bakgoo.Sleep("잠을");
            bakgoo.Sound("왈왈");
            Console.WriteLine();

            IAnimal nero = new Cat();
            nero.Name("네로");
            nero.Age(8);
            nero.Eat("사료");
            nero.Sleep("잠을");
            nero.Sound("야옹");
            Console.WriteLine();

            IAnimal baekma = new Hores();
            baekma.Name("백마");
            baekma.Age(15);
            baekma.Eat("사료");
            baekma.Sleep("잠을");
            baekma.Sound("히이이");
        }
    }
}
