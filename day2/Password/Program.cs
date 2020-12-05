using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataLoader("input.txt").DataList;
            var verifier = new PasswordVerifier(data);
            Console.WriteLine("Part1: " + verifier.CountValidPasswords1());
            Console.WriteLine("Part2: " + verifier.CountValidPasswords2());
        }
    }
}
