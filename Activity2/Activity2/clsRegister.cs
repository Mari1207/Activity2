using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    class clsRegister
    {
        string registerId;
        cslPerson librarian;
        List<cslPerson> User;
        List<cslPerson> LiblaryId;
        List<clsBooks> bookName;
        List<clsBooks> bookNumber;
        List<clsBooks> borrowedDate;
        List<clsBooks> returnedDate;
        List<clsBooks> dueDate;
        public void registerbook() { }
        public void noticeUser() { }
        public void registerNewUser() { 
        clsPerson newUser = new clsPerson();
        newUser.firstName ="Mari";
        newUser.lastName = "Morishita";
            newUser.Id = "B123";
            newUser.LiblaryId = "123456";
            newUser.address = "30Yonge st";
            newUser.phonenumber = "123-4556-7757";
            newUser.gender = "female";




            }
    }
}
