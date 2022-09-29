using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLessonWithMichael
{
    //the purpose of the PhoneFactory is to ask the user what type of phone they
    //want and then we will create a phone of that type for the user.   
    public class PhoneFactory 
    {
        //write a method that will produce a phone of whatever type we need
        public static IMobilePhone BuildPhone()  
        {
            Console.WriteLine($"What type of phone do you need?");

            var answer = Console.ReadLine();

            switch (answer.ToLower()) // the return type of this mess is IMobilePhone
            {
                case "blackberry":
                    return new Blackberry(); //behave like IMobile Phone
                case "nokia":
                    return new Nokia(); //behave like IMobile Phone
                case "galaxy":
                    return new Galaxy(); //behave like IMobile Phone
                default:
                    return new Nokia();

            }
        }
        //this method will return a collection of strings
        //I want this method to be able to return a list or an array

        public static IEnumerable<string> MakeCollection()
        {
          return new string[] { };   //list and arrays both return type INumerable
          return new List<string>();

        }

        //this method will return a collection of strings
        //I want this method to be able to return a list or an array
        //The method will be void.

        public static void MakeCollection(IEnumerable<string> collection) //this can pass in 
            //either an array or list as long as there are strings in it.  
        {
            foreach (var num in collection)
            {
                Console.WriteLine($"{num}");
            }
            //we can write this method and the foreach loop before we know what the user will 
            //give us (an array or list) because IEnumberable works with both.  
        }

    }
}
