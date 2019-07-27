using System;
namespace HelloWorld
{
    public class Person
    {
        String FirstName;
        String LastName;
        int a;

        public String Add(String FirstName, String LastName, int a)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.a = a;
            String name = "Hi I am " + FirstName + " " + LastName+ " and I am "+a+" year's old";
            return name;
        }
       

        //public void Introduce()

        //{
        //    Console.WriteLine("Hi my name is: " + FirstName + " " + LastName);
        //    Console.WriteLine("and i am " + a + "years old");
        //}
    }
}
