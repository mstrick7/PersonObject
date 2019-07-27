using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";

            //john.Introduce();

            //Person mary = new Person();
            //mary.FirstName = "Mary";
            //mary.LastName = "Jane";

            //mary.Introduce();

            Person matt = new Person();
            String Matt = matt.Add("Matthew", "Strickland", 36);

            //matt.Introduce();
         

            Person morgan = new Person();
            String Morgan = morgan.Add("Morgan", "Strickland", 32);
            


            //morgan.Introduce(); 

            Console.WriteLine(Matt);
            Console.WriteLine(Morgan);
         

        }

    }
}
