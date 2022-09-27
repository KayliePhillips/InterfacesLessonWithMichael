using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLessonWithMichael
{
    public class FunWithCollection
    {

        //how do I make a method?
        //This method will accept a collection and print its values.  

       //if I make the method static
        public static void PrintItems(IEnumerable<string> spamList)
            //IEnumbable -- is an interface
            //Specifices how collections should behave
            //List and Arrays conform to IEnumberable
        {
            foreach (var subscriber in spamList)
            {
                Console.WriteLine($"{subscriber}: \"You Suck\"");
            }
        }

        public static void Call(IMobilePhone phone)
        {
            phone.MakeCalls();
        }
    }
}
