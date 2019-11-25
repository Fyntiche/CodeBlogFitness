using CodeBlogFintess.BL.Controller;
using System;

namespace CodeBlogFintess.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложением CodeBlogFintess");
            
            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            DateTime.TryParse(Console.ReadLine(), out DateTime birthdate);

            Console.WriteLine("Введите вес");
            Double.TryParse(Console.ReadLine(), out double weight);

            Console.WriteLine("Введите рост");
            Double.TryParse(Console.ReadLine(), out double height);

            var userController = new UserController(
                                       name,
                                       gender,
                                       birthdate,
                                       weight,
                                       height

                );
            userController.;

        }
    }
}
