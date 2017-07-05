using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestAplication1.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Users.Add(new User{Name = "User_0", Mail = "User_0@mail.ru"});
            db.Users.Add(new User{Name = "User_1", Mail = "User_1@mail.ru"});
            db.Users.Add(new User{Name = "User_2", Mail = "User_2@mail.ru"});
            db.Users.Add(new User{Name = "User_3", Mail = "User_3@mail.ru"});

            base.Seed(db);
        }
    }
}