using MyDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(TestContext context)
        {
         

            context.Database.EnsureCreated();

            //check if there are any users already
            if (context.Users.Any()) { 
                
                return; // Database seeded successfully
            }

            List<User> users = new List<User>();

            for (int i=0; i<100; i++)
            {
                users.Add(new User {Vorname = 1 + i + " User Vorname ", Name = 1+i+" User Name", Email = 1 + i + "User@email.com" });
            }

            context.Users.AddRange(users);

            context.SaveChanges();


        }
    }
}
