using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLessonWithMichael
{
    public interface IMobilePhone //this is a contract that says if you use me you must
        // included everything and give it a scope.  
    {
        //Here is where I'm specifying a
        //behavior that a class should exhibit
        //Below are "behaviors" that a phone should have.  

        public void MakeCalls(); //stubbed out method (method w/ no implementation or scope)
        public void Text(string phoneNumber, string message);
        public void VideoCall();

    
    
    }
}
