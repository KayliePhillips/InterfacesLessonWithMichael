using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLessonWithMichael
{
    public class Galaxy : IMobilePhone
    {
        //implement the stubbed out methods from the IMobilePhone interface
        public void MakeCalls()
        {
            Console.WriteLine($"Galaxy: Calling so and so at such time");
        }

        public void Text(string phoneNumber, string message)
        {
            Console.WriteLine($"{phoneNumber}: \"{message}\" sent at {DateTime.Now}");
        }

        public void VideoCall()
        {
            Console.WriteLine($"{DateTime.Now}: Video Chat starting"); 
        }
    }
}
