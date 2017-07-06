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
            var users = db.Users;
            for (int i = 1; i <= 0; i++)
            {
                users.Add(new User { Name = "User"+i, Mail = "User"+i+"@mail.ru" });
            }
            base.Seed(db);
        }
    }
}