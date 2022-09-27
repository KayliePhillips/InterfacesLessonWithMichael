

//make a new Galaxy phone
using InterfacesLessonWithMichael;
using System.ComponentModel.DataAnnotations;

var galaxy = new Galaxy(); //instantiation --> making an instance of Galaxy class / object

Nokia nokia = new Nokia(); //explicit 
//a constructor is a special member method.

//Make a list to hold the IMobilePhones
var phones = new List<IMobilePhone>();
//add items to this list using . notation
phones.Add(galaxy);
phones.Add(nokia);

foreach (var mobile in phones) 
{
    Console.WriteLine("----------------------");
    mobile.MakeCalls();
    mobile.Text("555-555-5555", "Hi there");
    mobile.VideoCall();
    Console.WriteLine("----------------------");
}


//IEnumbable -- is an interface
//Specifices how collections should behave
//List and Arrays conform to IEnumberable


//Make a new array

var array = new string[] { "daniel@truecoders.io", "michael@truecoders.io", "tanner@truecoders.io" };

//Make a list
var List = new List<string>();
    List.Add("michael@truecoders.io");
    List.Add("daniel@trucodes.io");

FunWithCollection.PrintItems(array);

FunWithCollection.PrintItems(List);


var galaxy1 = new Galaxy();
var nokia1 = new Nokia();

FunWithCollection.Call(galaxy1);
FunWithCollection.Call(nokia1);

