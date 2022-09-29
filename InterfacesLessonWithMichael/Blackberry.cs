using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLessonWithMichael
{
    internal class Blackberry : IMobilePhone
    {
        public void MakeCalls()
        {
            throw new NotImplementedException();
        }

        public void Text(string phoneNumber, string message)
        {
            throw new NotImplementedException();
        }

        public void VideoCall()
        {
            Console.WriteLine($"Making important business video call with my blackberry.");
        }
    }
}
