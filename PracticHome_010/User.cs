using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace PracticHome_010
{
    public class User
    {
        public static string Login { get; set; }

        public static string Password { get; set; } 

        public static string ConfirmPassword { get; set; }


        public void UserLogin(string login, string password, string confirmPassword)
        {
           Login = login;
           Password = password; 
           ConfirmPassword= confirmPassword;
            
            char a = ' ';
           
            for (int i = 0; i < login.Length; i++)
            {
                if (login.Length < 20 && login[i] != a)
                {
                    Login = login;
                }
                else
                {
                    Console.WriteLine("The Login is not match Error!!!");
                    Console.WriteLine("---------------");
                    throw new WrongLoginException("Wrong Login Exception");
                }

            }
            Console.WriteLine($"Login is good: {login}");
            
            for (int j = 0; j < password.Length; j++)
            {
                if (password.Length < 20 && password[j] != a && password[j] != (int)0-9)
                {
                    Password = password;
                }
                if (password == confirmPassword)
                {
                    ConfirmPassword = confirmPassword;
                    
                }
                else
                {
                    Console.WriteLine("The Password is not match Error!!!");
                    Console.WriteLine("---------------");
                    throw new Exception("Error the password is not confirm");
                }
            }
            Console.WriteLine($"Password is good {password}");
            Console.WriteLine($"The password is confirm: {confirmPassword}");
            
        }





        
    }
}
