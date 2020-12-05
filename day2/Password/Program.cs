using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataLoader("input.txt").DataList;
            var verifier = new PasswordVerifier(data);
            Console.WriteLine(verifier.CountValidPasswords());
        }
    }
}
