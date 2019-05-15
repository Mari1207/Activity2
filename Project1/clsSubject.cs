using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class clsModule //programming in C#,SQL database development,etc
    {
        string name;
        DateTime starTime;
        DateTime endTime;
        clsPerson instructor; // instructors are people
        List<clsPerson> students;//so ate students
        string classroomNumber; //B10 or A01
        // what can s subject do? what actions can it perform?
        public decimal calculatePercentageOfApprovedStudents()
        {
            //M suffix identifies the number as decimal
            return 100.0M;
        }
        public decimal calculateStudentscore(clsPerson student)
        {
            return 100.0M;
        }
        public void genrateMockStudentList()
        { //Instantiate the class
            clsPerson newStudent = new clsPerson();
            //fill in information in the properties
            newStudent.lastname = "snow";
            newStudent.firstname = "John";
            newStudent.age = 30;
            newStudent.eyeColor = "BLACK";
            newStudent.height = 1.75m;
            newStudent.idCard = "100-99-0-000";

            //we can also assign objects to other object's properties
            Guid uniqueIdentifier = new Guid();
            newStudent.uniqueId = uniqueIdentifier;
            newStudent.hobbies = new List<string>();
            // or call ,ethods/functions
            newStudent.taketest("programming in C#");

        }
     }
}
