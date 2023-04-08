namespace PracticHome_010
{
    class User
    {

        public static bool IsValid(string login, string password, string confirmPassword)
        {
            try
            {
                if (login.Length < 20 && login.Contains(' '))
                    throw new WrongLoginException("The Login is not match Error!!!");
               
                if (password.Length < 20 && password.Contains(' ') && !password.Any(char.IsDigit))
                    throw new WrongPasswordException("The Password is not match Error!!!");
               
                if (!password.Equals(confirmPassword))
                    
                    throw new WrongPasswordException("Error the password is not confirm");


                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }

                

            
            
            
            
            
                


             
                
                    
                    
                
                
                
                    Console.WriteLine("The Password is not match Error!!!");
                    Console.WriteLine("---------------");
                    
                
            
            Console.WriteLine($"Password is good {password}");
            Console.WriteLine($"The password is confirm: {confirmPassword}");
            
        }





        
    }
}
