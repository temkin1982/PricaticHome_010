using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace PracticHome_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача. Введите пароль в одну переменную  и подтвержение этого пароля во вторую перменную.
            // Если переменные равны то всё хорошо конец программы.
            // Если пароли не равны генерируйте исключение  "Пароли не равны!!!!"
            // Если во время программы произошла ошибка обрабатывайте это исключение  в отдельном блоке catch

            //try
            //{
            //    string password = "asdfghjkl";
            //    string ConfirmPassword = "zxcvbnm";

            //    if (password == ConfirmPassword)
            //    {
            //        Console.WriteLine("end program");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The password is not match!!!");
            //        throw new Exception("Wrong password");
            //    }

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            // вторая задача из урока 10. 

            //try
            //{
            //    var login = new Login { Value = "dima@mail.ru", ConfirmLogin = "dima@gmail.com" };
            //    Console.WriteLine("The login is confirm");
            //}
            //catch (LoginException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //Console.WriteLine("---------------");
            //Console.ReadKey();

            // Домашнее задание //
            try
            {

                User user = new User();
                user.UserLogin("dima@mail.ru", "9asf9", "9asf9");

                Console.WriteLine($"User + Login: {user}");
            }
            catch (WrongLoginException ex)
            {
               Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();




        }
            






    }





















    

}