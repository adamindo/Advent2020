using System;

namespace Passport
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new DataLoader("input.txt");
            var passports = loader.Passports;
            var verifier = new PassportVerifier(passports);
            Console.WriteLine("Part1: " + verifier.CountValidPassports());
        }
    }
}
