using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle a = new Angle ();
            Console.WriteLine("Введите значение градуса °");
            a.Gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение угловых минут");
            a.Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение угловых секунд");
            a.Sec = Convert.ToInt32(Console.ReadLine());
            int x = a.Gradus * 2;
            Console.WriteLine("{0}° {1}' {2}\" = {3} рад", a.Gradus, a.Min, a.Sec, a.ToRadians());
        }
    }
}
