using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_5_kel41
{
    class Program
    {
        static void Main(string[] args)
        {
            string email, password;

            Console.Write("Email : ");
            email = Console.ReadLine();
            Console.Write("Password : ");
            password = Console.ReadLine();

            userService data = new userService(email, password);
            data.login();

            Console.ReadKey();
        }
    }
}
