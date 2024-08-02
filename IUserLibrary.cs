using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    public interface IUserLibrary
    {
        void AdminMainPage();
        void AddNewUser();
        void DeleteUser();
        void ViewUsers();
    }
}
