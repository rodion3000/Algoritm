using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Algoritm
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите ваш логин");
            User.Login = Console.ReadLine();
            Console.WriteLine("Введите ваше имя");
            User.Name = Console.ReadLine();
            Console.WriteLine($"Приветствую {User.Name}, ваш логин {User.Login} ");
            Console.WriteLine("Имеете ли вы премиум подписку?");
            User.Premium = Console.ReadLine();
            if (User.Premium == "нет")
            { User.ShowAds(); }


        }

    }



}