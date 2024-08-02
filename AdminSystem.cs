using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    public class AdminSystem : IUserLibrary
    {
        private List<User> users = new List<User>();
        public void AdminMainPage()
        {
            Console.WriteLine("Welcome Administrator. Choose an option:");
            Console.WriteLine("A. Add new user" + 
                                "\nB. View Users" + 
                                "\nC. Delete user");
        }
        public void AddNewUser()
        {

        }
        public void ViewUsers()
        {

        }
        public void DeleteUser()
        {

        }
    }
}
