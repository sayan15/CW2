using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    public class UserModel
    {
        public  string RegisterUser(UserDetails info)
        {
            

            User user = new User();
            user.UserName = info.UserName;
            user.Mail = info.Mail;
            user.Password = info.Password;

            try {
                CW2_SystemDBContainer db = new CW2_SystemDBContainer();
                var usrName = db.Users
                 .Where(s => s.UserName == info.UserName)
                 .FirstOrDefault<User>();

                if(usrName!=null)
                {
                    return "UserName Already Exist";
                }
                var mail = db.Users.Where(s => s.UserName == info.Mail).FirstOrDefault<User>();
                if (mail!=null)
                {
                    return "Mail address Already Exist";
                }

                db.Users.Add(user);
                db.SaveChanges();
                
            }
            catch(Exception e)
            {
                return e.Message;
            }
            return "Succesfully Added";
        }
        public String LoginUser(UserDetails info)
        {
            try
            {
                CW2_SystemDBContainer db = new CW2_SystemDBContainer();
                var usr = db.Users
                 .Where(s => s.UserName == info.UserName && s.Password==info.Password)
                 .FirstOrDefault<User>();
                if(usr!=null)
                {
                    return "exist";
                }
                else
                {
                    return "UserName or Password is Incorrect";
                }
            }
            catch(Exception e)
            {
                return e.Message;
            }
                return "UserName or Password is Incorrect";
        }

        public int GetID(UserDetails info)
        {
            try
            {
                CW2_SystemDBContainer db = new CW2_SystemDBContainer();
                var usr = db.Users
                 .Where(s => s.UserName == info.UserName && s.Password == info.Password)
                 .FirstOrDefault<User>();
                if (usr != null)
                {
                    return usr.Id;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
            return 0;
        }
    }
}
