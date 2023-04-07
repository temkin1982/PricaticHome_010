using System.Security.AccessControl;

namespace PracticHome_010
{
    class Login
    {
        private string confirmLogin;

        public string Value { get; set; } = "";

        public string ConfirmLogin
        {
            get => confirmLogin;
            set
            {
                if (value == Value)
                {
                    confirmLogin = value;
                    Console.WriteLine("end program");
                }
                else
                {   
                    Console.WriteLine("The Login is not match Error!!!");
                    Console.WriteLine("---------------");
                    throw new LoginException("Wrong Login");
                }
            }
        }
    }
}
