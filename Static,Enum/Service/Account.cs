using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Account : IAccount
    {

        public  void CheckAccount(int roleid, string email, string password)
        {
            if (roleid == 1 && email == "test@code.edu.az" && password == "test12345")
            {
                Console.WriteLine("Giriş uğurludur");
            }
            else if ( email != "test@code.edu.az" || password != "test12345")
            {
                Console.WriteLine("Email ve ya password sehvdir");
            }
            else
            {
                Console.WriteLine("Giriş üçün icazeniz yoxdur");
            }
        }

        public void CheckAccount()
        {
            throw new NotImplementedException();
        }
    }
}
