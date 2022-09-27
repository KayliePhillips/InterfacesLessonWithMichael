using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLessonWithMichael
{
    public class Nokia : IMobilePhone
    {
        public void MakeCalls()
        {
            Console.WriteLine($"blah blah blah"); 
        }

        public void Text(string phoneNumber, string message)   
        {
            Console.WriteLine($"texting {phoneNumber}; \"{message}\" from Nokia");
        }

        public void VideoCall()
        {
            Console.WriteLine($"We're sorry.  Nokia doesn't have this");
        }
    }
}
