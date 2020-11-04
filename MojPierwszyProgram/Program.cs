using System;


namespace MojPierwszyProgram
{
    class Program
    {
        //To jest mój komentarz
        static void Main(string[] args)
        {
            string imie = "Andrzej";

            imie = args[0].ToString();
             
            // MojDrugiProgram.Program2.Kolo();
            Console.WriteLine(imie);
            Console.ReadLine();
        }

        //static string imie()
        //{
        //    return "Adam";
        //}
    }
}
