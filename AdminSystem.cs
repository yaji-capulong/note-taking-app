﻿using System;
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
            while (true) {
                Console.Clear();
                Console.WriteLine("Welcome Administrator. Choose an option:");
                Console.WriteLine("A. Add new user" +
                                    "\nB. View Users" +
                                    "\nC. Delete user" +
                                    "\nD. Log Out");
                string choice = Console.ReadLine().ToLower();

                if (choice == "a")
                {
                    Console.Clear();
                    AddNewUser();
                }
                else if (choice == "b")
                {
                    Console.Clear();
                    ViewUsers();
                }
                else if (choice == "c") 
                { 
                    Console.Clear();
                    DeleteUser();
                }
            }
            
        }
        public void AddNewUser()
        {
            Console.Write("Add New User\nEnter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            User newUser = new User() { Username = username, Password = password};
            users.Add(newUser);

            Console.WriteLine("\nUser added successfully.\nPress any key to continue.");
            Console.ReadKey();
        }
        public void ViewUsers()
        {

        }
        public void DeleteUser()
        {

        }
    }
}
