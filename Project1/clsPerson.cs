using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class clsPerson
    {
        //ALL PROPERTIES AND METHODS HERE
        string firstname;//JOHN
        string lastname;//DOE
        int age;//31
        decimal height; //because we are using meters
        string eyeColor; // can be BLACK BROWN GREEN ETC
        string idCard;// something like A290-08SD-088S
        Guid uniqueId; // something more complex..'285637b429-198e-1000099400db'
        List<string> hobbies; //because you can have many

        //ALL METHODS/FUNCTIONS HERE -think about a  school system
        public void registrerAsNewStudent(decimal paidAmount, string programName)
        { //code goes here
        }
        public void taketest(string className) { }
        public void printReport() { }
    }
}
