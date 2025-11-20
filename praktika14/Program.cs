using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: Музыкальные инструменты\n");
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
            foreach (var i in band) i.Play();
            Console.WriteLine();

            Console.WriteLine("Задание 2: Сообщения\n");
            Message[] messages = { new Email(), new SMS(), new Message() };
            foreach (var m in messages) m.Send();
            Console.WriteLine();

            Console.WriteLine("Задание 3: Еда\n");
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch) f.Eat();
            Console.WriteLine();

            Console.WriteLine("Задание 4: Фигуры\n");
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes) Console.WriteLine(s.Draw());
            Console.WriteLine();

            Console.WriteLine("Задание 5: Игроки\n");
            Player[] team = { new Warrior(), new Archer(), new Player() };
            foreach (var p in team) p.Attack();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
